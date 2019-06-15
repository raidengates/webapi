using Article.Framework.Data.Entities;
using Article.Framework.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Article.Framework.Domain;
using AutoMapper;

namespace Article.Framework.Services
{
    public class CategoryServices : SqlCommand, ICategoryServices
    {
        ArtDBContext _artDBContext;
        private readonly DbSet<Category> _category;
        private readonly IMapper _mapper;

        public CategoryServices(ArtDBContext artDBContext, IMapper mapper)
        {
            _artDBContext = artDBContext;
            _category = _artDBContext.Set<Category>();
            _mapper = mapper;
        }

        #region  Lấy thông tin danh mục không đệ quy
        public Task<List<Category>> GetCategoriesBySite(int site) => Task.Run(() => CategoriesBySite(site));
        private List<Category> CategoriesBySite(int site) => _category.Where(category => category.CategorySite == site).ToList();
        #endregion


        #region lấy thông tin danh mục có đệ quy
        public Task<IEnumerable<CategoriesRecursive>> GetCategoriesRecursive() => Task.Run(() => ResultCategoriesRecursive());

        private IEnumerable<CategoriesRecursive> ResultCategoriesRecursive()
        {
            var _categories = _category.Where(x => x.CategoryParentId == 0).ToList();
            var _categoriesRecursive = _mapper.Map<IEnumerable<CategoriesRecursive>>(_categories);
            _categoriesRecursive = Traverse(_categoriesRecursive);
            return _categoriesRecursive;
        }

        private IEnumerable<CategoriesRecursive> Traverse(IEnumerable<CategoriesRecursive> categories)
        {
            foreach (var category in categories)
            {
                var _categories = _category.Where(x => x.CategoryParentId == category.CategoryId).ToList();
                var subCategories = _mapper.Map<IEnumerable<CategoriesRecursive>>(_categories);
                category.Children = subCategories;
                category.Children = Traverse(category.Children).ToList();
            }
            return categories;
        } 
        #endregion

    }

    public class SqlCommand
    {
        /// <summary>
        ///   {0} =  @SiteID
        /// </summary>
        protected string CTE_Category_All { get {
                return @"with CTE_Category  as
					(select rn = ROW_NUMBER() OVER  (ORDER BY CategoryOrder  desc), CategoryID, CategoryName, CategoryParentId, CategoryDescription,

					 CategoryActived, CategoryOrder,   CategoryTagName, CategorySite, 0 AS alevel, CAST (str(CategoryOrder) + '_' AS nvarchar(500))as sort, CAST('' as nvarchar(500)) 

						as iCategoryName from Categories where ((CategoryParentId=0) or (CategoryParentId is NULL)) AND CategorySite = {0}
							 UNION ALL 
						select   a.rn, b.CategoryID, b.CategoryName, b.CategoryParentId, b.CategoryDescription, b.CategoryActived, b.CategoryOrder, 

					b.CategoryTagName, b.CategorySite, a.alevel+1,  CAST(a.sort + str(b.CategoryOrder)+'_' AS nvarchar(500)) 

					 AS sort, CAST( a.iCategoryName+ '__ ' as nvarchar(500)) as  iCategoryName 

					from  CTE_Category as a INNER JOIN Categories as b on a.CategoryID= b.CategoryParentId)

					select CategoryID, CategoryName, CategoryParentId, CategoryDescription, CategoryActived, CategoryOrder,

					CategoryTagName,  CategorySite,  alevel, sort, CAST(iCategoryName + CategoryName as nvarchar(500)) as iCategoryName 	 

					 from CTE_Category order by rn , sort , CategoryOrder";
            } }
    }


}

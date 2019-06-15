using Article.Framework.Data.Entities;
using Article.Framework.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Article.Framework.Services
{
    public class CategoryServices : SqlCommand, ICategoryServices
    {
        ArtDBContext _artDBContext;
        private readonly DbSet<Category> _category;
        public CategoryServices(ArtDBContext artDBContext)
        {
            _artDBContext = artDBContext;
            _category = _artDBContext.Set<Category>();
        }
        /// <summary>
        /// lấy danh mục
        /// </summary>
        /// <param name="site">ID site</param>
        /// <returns></returns>
        public Task<List<Category>> GetAllCategoryBySite(int site) => Task.Run(() => GetList(site));
        private List<Category> GetList(int site) => _category.Where(category => category.CategorySite == site).ToList();

        public Task<List<CTE_Category>> GetAllCategoryBySite(int site, int _CategoryId, int pCurrentPage, int vPageSize, ref int vCount)
        {
            int o_Count = 0;
            vCount = o_Count;
            return Task.Run(() => GetList(site, _CategoryId, pCurrentPage, vPageSize, ref o_Count));
        }
        private List<CTE_Category> GetList(int site, int vCM_ID, int pCurrentPage, int vPageSize, ref int vCount)

        => _artDBContext.CTE_Categories.FromSql(CTE_Category_All, 0).ToList();


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

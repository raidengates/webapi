using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Article.Framework.Data.Entities;
using Article.Framework.Domain;

namespace Article.Framework.Services.Interface
{
    public interface ICategoryServices
    {
        Task<List<Category>> GetCategoriesBySite(int site);
        Task<IEnumerable<CategoriesRecursive>> GetCategoriesRecursive();
    }
}

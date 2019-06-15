using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Article.Framework.Data.Entities;

namespace Article.Framework.Services.Interface
{
    public interface ICategoryServices
    {
        Task<List<Category>> GetAllCategoryBySite(int site);
    }
}

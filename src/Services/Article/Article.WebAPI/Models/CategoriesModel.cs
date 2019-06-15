using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Article.WebAPI.Models
{
    public class CategoriesModel
    {
        public int CategoryID { get; set; }
        public int CategoryParentID { get; set; }
        public int CategorySite { get; set; }
        public string CategoryKeySearch { get; set; }

    }
}

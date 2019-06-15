using Article.Framework.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Framework.Domain
{
    public class CategoriesRecursive : Category
    {
        public int CategoryId { get; set; }
        public IEnumerable<CategoriesRecursive>  Children { get; set; }
    }
}

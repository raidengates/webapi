using System;
using System.Collections.Generic;
using System.Text;

namespace Article.Framework.Data.Entities
{
    public partial class CTE_Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int CategoryParentId { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryActived { get; set; }
        public int CategoryOrder { get; set; }
        public string CategoryTagName { get; set; }
        public int CategorySite { get; set; }
        public int alevel { get; set; }
        public string sort { get; set; }
        public string iCategoryName { get; set; }
    }
}

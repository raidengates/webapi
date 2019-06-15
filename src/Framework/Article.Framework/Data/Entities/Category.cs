using System;
using System.Collections.Generic;

namespace Article.Framework.Data.Entities
{
    public partial class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryTitle { get; set; }
        public string CategoryUrl { get; set; }
        public string CategorySign { get; set; }
        public string CategoryTagName { get; set; }
        public string CategoryTagSign { get; set; }
        public string CategoryTagUrl { get; set; }
        public int CategoryParentId { get; set; }
        public int? CategoryOrder { get; set; }
        public bool? CategoryActived { get; set; }
        public string CategoryKeyword { get; set; }
        public string CategoryDescription { get; set; }
        public DateTime? CategoryCreated { get; set; }
        public DateTime? CategoryModified { get; set; }
        public int? CategoryCreatedBy { get; set; }
        public int? CategoryModifiedBy { get; set; }
        public int CategorySite { get; set; }
    }
}
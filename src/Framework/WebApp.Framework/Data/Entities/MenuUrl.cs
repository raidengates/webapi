using System;
using System.Collections.Generic;

namespace WebApp.Framework.Data.Entities
{
    public partial class MenuUrl
    {
        public int MenuUrlID { get; set; }
        public int MenuID { get; set; }
        public string Url { get; set; }
        public int HttpStatus { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }

        public virtual MenuBar Menu { get; set; }
    }
}
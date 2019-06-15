using System;
using System.Collections.Generic;

namespace WebApp.Framework.Data.Entities
{
    public partial class MenuBar
    {
        public MenuBar()
        {
            MenuPermissions = new HashSet<MenuPermission>();
            MenuUrls = new HashSet<MenuUrl>();
        }

        public int MenuID { get; set; }
        public string MenuName { get; set; }
        public int? MenuOrder { get; set; }
        public int? SiteID { get; set; }
        public bool? IsVisible { get; set; }
        public int? ParentID { get; set; }
        public string IconFile { get; set; }
        public bool? DisableLink { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string KeyWords { get; set; }
        public bool? IsDeleted { get; set; }
        public string Url { get; set; }
        public string SkinSrc { get; set; }
        public string ContainerSrc { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? RefreshInterval { get; set; }
        public string PageHeadText { get; set; }
        public bool? IsSecure { get; set; }
        public bool? PermanentRedirect { get; set; }
        public int? CreatedByUserID { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public int? LastModifiedByUserID { get; set; }
        public DateTime? LastModifiedOnDate { get; set; }
        public string IconFileLarge { get; set; }
        public int? MenuLevel { get; set; }
        public string TabPath { get; set; }
        public bool? HasBeenPublished { get; set; }
        public bool? IsSystem { get; set; }

        public virtual ICollection<MenuPermission> MenuPermissions { get; set; }
        public virtual ICollection<MenuUrl> MenuUrls { get; set; }
    }
}
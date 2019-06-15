using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApp.Framework.Data.Entities
{
    public partial class AppwebapiContext : DbContext
    {
        public AppwebapiContext()
        {
        }

        public AppwebapiContext(DbContextOptions<AppwebapiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MenuBar> MenuBars { get; set; }
        public virtual DbSet<MenuPermission> MenuPermissions { get; set; }
        public virtual DbSet<MenuUrl> MenuUrls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=AppWebAPI;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<MenuBar>(entity =>
            {
                entity.HasKey(e => e.MenuID);

                entity.ToTable("MenuBar");

                entity.Property(e => e.ContainerSrc).HasMaxLength(200);

                entity.Property(e => e.CreatedByUserID).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.DisableLink).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HasBeenPublished).HasDefaultValueSql("((0))");

                entity.Property(e => e.IconFile).HasMaxLength(50);

                entity.Property(e => e.IconFileLarge).HasMaxLength(200);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSecure).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSystem).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsVisible).HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyWords).HasMaxLength(300);

                entity.Property(e => e.LastModifiedByUserID).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MenuLevel).HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.MenuOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentID).HasDefaultValueSql("((0))");

                entity.Property(e => e.PermanentRedirect).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiteID).HasDefaultValueSql("((0))");

                entity.Property(e => e.SkinSrc).HasMaxLength(200);

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TabPath).HasMaxLength(250);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Url).HasMaxLength(500);
            });

            modelBuilder.Entity<MenuPermission>(entity =>
            {
                entity.ToTable("MenuPermission");

                entity.Property(e => e.RoleID).HasDefaultValueSql("((-1))");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.MenuPermissions)
                    .HasForeignKey(d => d.MenuID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuPermission_MenuBar");
            });

            modelBuilder.Entity<MenuUrl>(entity =>
            {
                entity.ToTable("MenuUrl");

                entity.Property(e => e.CreatedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.MenuUrls)
                    .HasForeignKey(d => d.MenuID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuUrl_MenuBar");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
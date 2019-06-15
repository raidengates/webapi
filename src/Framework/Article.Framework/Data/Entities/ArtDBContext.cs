﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Article.Framework.Data.Entities
{
    public partial class ArtDBContext : DbContext
    {
        public ArtDBContext()
        {
        }

        public ArtDBContext(DbContextOptions<ArtDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<CTE_Category> CTE_Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ArticleWepAPI;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryActived)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CategoryCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CategoryDescription)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CategoryKeyword)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CategoryModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CategoryOrder).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CategorySign).HasMaxLength(250);

                entity.Property(e => e.CategoryTagName).HasMaxLength(250);

                entity.Property(e => e.CategoryTagSign).HasMaxLength(250);

                entity.Property(e => e.CategoryTagUrl).HasMaxLength(250);

                entity.Property(e => e.CategoryTitle)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CategoryUrl).HasMaxLength(250);
            });

            modelBuilder.Entity<CTE_Category>(entity => {
                entity.Property(e => e.CategoryID).HasColumnName("CategoryID");
                entity.Property(e => e.CategoryName).HasColumnName("CategoryName");
                entity.Property(e => e.CategoryParentId).HasColumnName("CategoryParentId");
                entity.Property(e => e.CategoryDescription).HasColumnName("CategoryDescription");
                entity.Property(e => e.CategoryActived).HasColumnName("CategoryActived");
                entity.Property(e => e.CategoryOrder).HasColumnName("CategoryOrder");
                entity.Property(e => e.CategoryTagName).HasColumnName("CategoryTagName");
                entity.Property(e => e.CategorySite).HasColumnName("CategorySite");
                entity.Property(e => e.alevel).HasColumnName("alevel");
                entity.Property(e => e.sort).HasColumnName("sort");
                entity.Property(e => e.iCategoryName).HasColumnName("iCategoryName");
            });

           

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
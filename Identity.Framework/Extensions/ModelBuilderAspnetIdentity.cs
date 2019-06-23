using Identity.Framework.Entities;
using Microsoft.EntityFrameworkCore;

namespace Identity.Framework.Extensions
{
    internal class ModelBuilderAspnetIdentity
    {
        public virtual void AspNetIdentity(ModelBuilder builder)
        {
            builder.Entity<IdentityFrameworkUser>(entity =>
            {
                entity.ToTable(name: "AspNetUser", schema: "Security");
                entity.Property(e => e.Id).HasColumnName("AspNetUserId");

            });

            builder.Entity<IdentityFrameworkRole>(entity =>
            {
                entity.ToTable(name: "AspNetRole", schema: "Security");
                entity.Property(e => e.Id).HasColumnName("AspNetRoleId");

            });

            builder.Entity<IdentityFrameworkUserClaim>(entity =>
            {
                entity.ToTable("AspNetUserClaim", "Security");
                entity.Property(e => e.UserId).HasColumnName("AspNetUserId");
                entity.Property(e => e.Id).HasColumnName("AspNetUserClaimId");

            });

            builder.Entity<IdentityFrameworkUserLogin>(entity =>
            {
                entity.ToTable("AspNetUserLogin", "Security");
                entity.Property(e => e.UserId).HasColumnName("AspNetUserId");

            });

            builder.Entity<IdentityFrameworkRoleClaim>(entity =>
            {
                entity.ToTable("AspNetRoleClaim", "Security");
                entity.Property(e => e.Id).HasColumnName("AspNetRoleClaimId");
                entity.Property(e => e.RoleId).HasColumnName("AspNetRoleId");
            });

            builder.Entity<IdentityFrameworkUserRole>(entity =>
            {
                entity.ToTable("AspNetUserRole", "Security");
                entity.Property(e => e.UserId).HasColumnName("AspNetUserId");
                entity.Property(e => e.RoleId).HasColumnName("AspNetRoleId");

            });


            builder.Entity<IdentityFrameworkUserToken>(entity =>
            {
                entity.ToTable("AspNetUserToken", "Security");
                entity.Property(e => e.UserId).HasColumnName("AspNetUserId");

            });
        }
    }
}
using Identities.WebAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace Identities.WebAPI.Extensions
{
    internal class ModelBuilderAspnetIdentity
    {
        public virtual void AspNetIdentity(ModelBuilder builder)
        {
            builder.Entity<IdentitiesWebAPIUser>(entity =>
            {
                entity.ToTable(name: "AspNetUser", schema: "Security");
                entity.Property(e => e.Id).HasColumnName("AspNetUserId");

            });

            builder.Entity<IdentitiesWebAPIRole>(entity =>
            {
                entity.ToTable(name: "AspNetRole", schema: "Security");
                entity.Property(e => e.Id).HasColumnName("AspNetRoleId");

            });

            builder.Entity<IdentitiesWebAPIUserClaim>(entity =>
            {
                entity.ToTable("AspNetUserClaim", "Security");
                entity.Property(e => e.UserId).HasColumnName("AspNetUserId");
                entity.Property(e => e.Id).HasColumnName("AspNetUserClaimId");

            });

            builder.Entity<IdentitiesWebAPIUserLogin>(entity =>
            {
                entity.ToTable("AspNetUserLogin", "Security");
                entity.Property(e => e.UserId).HasColumnName("AspNetUserId");

            });

            builder.Entity<IdentitiesWebAPIRoleClaim>(entity =>
            {
                entity.ToTable("AspNetRoleClaim", "Security");
                entity.Property(e => e.Id).HasColumnName("AspNetRoleClaimId");
                entity.Property(e => e.RoleId).HasColumnName("AspNetRoleId");
            });

            builder.Entity<IdentitiesWebAPIUserRole>(entity =>
            {
                entity.ToTable("AspNetUserRole", "Security");
                entity.Property(e => e.UserId).HasColumnName("AspNetUserId");
                entity.Property(e => e.RoleId).HasColumnName("AspNetRoleId");

            });


            builder.Entity<IdentitiesWebAPIUserToken>(entity =>
            {
                entity.ToTable("AspNetUserToken", "Security");
                entity.Property(e => e.UserId).HasColumnName("AspNetUserId");

            });
        }
    }
}
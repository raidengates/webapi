using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace Identities.WebAPI.Migrations
{
    [DbContext(typeof(IdentitiesWebAPIDbContext))]
    partial class IdentitiesWebAPIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Identity.Framework.Entities.IdentitiesWebAPIRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AspNetRoleId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("IdentitiesWebAPIRole", "Security");
                });

            modelBuilder.Entity("Identity.Framework.Entities.IdentitiesWebAPIRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AspNetRoleClaimId");

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId")
                        .HasColumnName("AspNetRoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("IdentitiesWebAPIRoleClaim", "Security");
                });

            modelBuilder.Entity("Identity.Framework.Entities.IdentitiesWebAPIUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AspNetUserId");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("IdentitiesWebAPIUser", "Security");
                });

            modelBuilder.Entity("Identity.Framework.Entities.IdentitiesWebAPIUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AspNetUserClaimId");

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId")
                        .HasColumnName("AspNetUserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("IdentitiesWebAPIUserClaim", "Security");
                });

            modelBuilder.Entity("Identity.Framework.Entities.IdentitiesWebAPIUserLogin", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId")
                        .HasColumnName("AspNetUserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("IdentitiesWebAPIUserLogin", "Security");
                });

            modelBuilder.Entity("Identity.Framework.Entities.IdentitiesWebAPIUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnName("AspNetUserId");

                    b.Property<int>("RoleId")
                        .HasColumnName("AspNetRoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("IdentitiesWebAPIUserRole", "Security");
                });

            modelBuilder.Entity("Identity.Framework.Entities.IdentitiesWebAPIUserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnName("AspNetUserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("IdentitiesWebAPIUserToken", "Security");
                });

            modelBuilder.Entity("Identity.Framework.Entities.IdentitiesWebAPIRoleClaim", b =>
                {
                    b.HasOne("Identity.Framework.Entities.IdentitiesWebAPIRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Identity.Framework.Entities.IdentitiesWebAPIUserClaim", b =>
                {
                    b.HasOne("Identity.Framework.Entities.IdentitiesWebAPIUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Identity.Framework.Entities.IdentitiesWebAPIUserLogin", b =>
                {
                    b.HasOne("Identity.Framework.Entities.IdentitiesWebAPIUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Identity.Framework.Entities.IdentitiesWebAPIUserRole", b =>
                {
                    b.HasOne("Identity.Framework.Entities.IdentitiesWebAPIRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Identity.Framework.Entities.IdentitiesWebAPIUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

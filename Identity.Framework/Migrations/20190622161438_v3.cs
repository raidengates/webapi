using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Identity.Framework.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Security");

            migrationBuilder.CreateTable(
                name: "IdentityFrameworkRole",
                schema: "Security",
                columns: table => new
                {
                    AspNetRoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityFrameworkRole", x => x.AspNetRoleId);
                });

            migrationBuilder.CreateTable(
                name: "IdentityFrameworkUser",
                schema: "Security",
                columns: table => new
                {
                    AspNetUserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityFrameworkUser", x => x.AspNetUserId);
                });

            migrationBuilder.CreateTable(
                name: "IdentityFrameworkUserToken",
                schema: "Security",
                columns: table => new
                {
                    AspNetUserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityFrameworkUserToken", x => new { x.AspNetUserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "IdentityFrameworkRoleClaim",
                schema: "Security",
                columns: table => new
                {
                    AspNetRoleClaimId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    AspNetRoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityFrameworkRoleClaim", x => x.AspNetRoleClaimId);
                    table.ForeignKey(
                        name: "FK_IdentityFrameworkRoleClaim_IdentityFrameworkRole_AspNetRoleId",
                        column: x => x.AspNetRoleId,
                        principalSchema: "Security",
                        principalTable: "IdentityFrameworkRole",
                        principalColumn: "AspNetRoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdentityFrameworkUserClaim",
                schema: "Security",
                columns: table => new
                {
                    AspNetUserClaimId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    AspNetUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityFrameworkUserClaim", x => x.AspNetUserClaimId);
                    table.ForeignKey(
                        name: "FK_IdentityFrameworkUserClaim_IdentityFrameworkUser_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalSchema: "Security",
                        principalTable: "IdentityFrameworkUser",
                        principalColumn: "AspNetUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdentityFrameworkUserLogin",
                schema: "Security",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    AspNetUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityFrameworkUserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_IdentityFrameworkUserLogin_IdentityFrameworkUser_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalSchema: "Security",
                        principalTable: "IdentityFrameworkUser",
                        principalColumn: "AspNetUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IdentityFrameworkUserRole",
                schema: "Security",
                columns: table => new
                {
                    AspNetUserId = table.Column<int>(nullable: false),
                    AspNetRoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityFrameworkUserRole", x => new { x.AspNetUserId, x.AspNetRoleId });
                    table.ForeignKey(
                        name: "FK_IdentityFrameworkUserRole_IdentityFrameworkRole_AspNetRoleId",
                        column: x => x.AspNetRoleId,
                        principalSchema: "Security",
                        principalTable: "IdentityFrameworkRole",
                        principalColumn: "AspNetRoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IdentityFrameworkUserRole_IdentityFrameworkUser_AspNetUserId",
                        column: x => x.AspNetUserId,
                        principalSchema: "Security",
                        principalTable: "IdentityFrameworkUser",
                        principalColumn: "AspNetUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "Security",
                table: "IdentityFrameworkRole",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IdentityFrameworkRoleClaim_AspNetRoleId",
                schema: "Security",
                table: "IdentityFrameworkRoleClaim",
                column: "AspNetRoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "Security",
                table: "IdentityFrameworkUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "Security",
                table: "IdentityFrameworkUser",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IdentityFrameworkUserClaim_AspNetUserId",
                schema: "Security",
                table: "IdentityFrameworkUserClaim",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityFrameworkUserLogin_AspNetUserId",
                schema: "Security",
                table: "IdentityFrameworkUserLogin",
                column: "AspNetUserId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityFrameworkUserRole_AspNetRoleId",
                schema: "Security",
                table: "IdentityFrameworkUserRole",
                column: "AspNetRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityFrameworkRoleClaim",
                schema: "Security");

            migrationBuilder.DropTable(
                name: "IdentityFrameworkUserClaim",
                schema: "Security");

            migrationBuilder.DropTable(
                name: "IdentityFrameworkUserLogin",
                schema: "Security");

            migrationBuilder.DropTable(
                name: "IdentityFrameworkUserRole",
                schema: "Security");

            migrationBuilder.DropTable(
                name: "IdentityFrameworkUserToken",
                schema: "Security");

            migrationBuilder.DropTable(
                name: "IdentityFrameworkRole",
                schema: "Security");

            migrationBuilder.DropTable(
                name: "IdentityFrameworkUser",
                schema: "Security");
        }
    }
}

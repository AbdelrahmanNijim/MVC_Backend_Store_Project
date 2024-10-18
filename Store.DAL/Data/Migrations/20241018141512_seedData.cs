using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Store.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "236d6fba-1333-4fe7-811f-53e23ebeddb9", null, "superadmin", "SUPERADMIN" },
                    { "2ce5c05f-e016-4c76-8c24-1a93f8c42f87", null, "admin", "ADMIN" },
                    { "e34f0143-a0e5-4193-995d-dcb08c459037", null, "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullNamme", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a0893e8-2ef7-4e75-a0f2-db89ca8a27b7", 0, null, "c5dc4779-fd69-402e-8fe9-47685d20766a", "admin@comp.com", true, null, false, null, "ADMIN@COMP.COM", "ADMIN@COMP.COM", "AQAAAAIAAYagAAAAED86S5uMoXe5uJ52SEpeZNcpTaCSfq/B9ZG6fIxYNG01qp6TaB8AHhd3wmWU/FlFOQ==", null, false, "97e46687-4c49-413d-81b7-ca86b9be17f6", false, "admin@comp.com" },
                    { "134b54cd-8edb-4d09-a87b-53f70340088b", 0, null, "60bc3435-a131-4650-b8ed-f60d4716484c", "superadmin@comp.com", true, null, false, null, "SUPERADMIN@COMP.COM", "SUPERADMIN@COMP.COM", "AQAAAAIAAYagAAAAEMZHbf/Wdfbhb0Vi0PHfAnBEyeUIKgXBqizHDgJ1A0hIpAUdZ+1ESMYyeeO0mq6EYg==", null, false, "82d3afd1-12e5-4230-811a-bf54009c249e", false, "superadmin@comp.com" },
                    { "6d83fcbf-460c-420d-ad21-5946deb6d1e7", 0, null, "86e2ef39-ba30-4388-b97b-364cbfbaad48", "user@comp.com", true, null, false, null, "USER@COMP.COM", "USER@COMP.COM", "AQAAAAIAAYagAAAAEFmuNQgLyLVuF4CAeWhMlY94ShsB39hVjvSILM7IVVuxopi2oQrAdDtXfEg4+Maf4A==", null, false, "f7c4af4f-71ec-4056-a467-ec63dd40ca15", false, "user@comp.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2ce5c05f-e016-4c76-8c24-1a93f8c42f87", "0a0893e8-2ef7-4e75-a0f2-db89ca8a27b7" },
                    { "236d6fba-1333-4fe7-811f-53e23ebeddb9", "134b54cd-8edb-4d09-a87b-53f70340088b" },
                    { "e34f0143-a0e5-4193-995d-dcb08c459037", "6d83fcbf-460c-420d-ad21-5946deb6d1e7" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2ce5c05f-e016-4c76-8c24-1a93f8c42f87", "0a0893e8-2ef7-4e75-a0f2-db89ca8a27b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "236d6fba-1333-4fe7-811f-53e23ebeddb9", "134b54cd-8edb-4d09-a87b-53f70340088b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e34f0143-a0e5-4193-995d-dcb08c459037", "6d83fcbf-460c-420d-ad21-5946deb6d1e7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "236d6fba-1333-4fe7-811f-53e23ebeddb9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ce5c05f-e016-4c76-8c24-1a93f8c42f87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e34f0143-a0e5-4193-995d-dcb08c459037");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a0893e8-2ef7-4e75-a0f2-db89ca8a27b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134b54cd-8edb-4d09-a87b-53f70340088b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d83fcbf-460c-420d-ad21-5946deb6d1e7");
        }
    }
}

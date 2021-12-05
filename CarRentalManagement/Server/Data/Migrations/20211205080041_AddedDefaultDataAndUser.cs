using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "c7eafdef-dd17-4973-8ef0-3a00e3c8dc9a", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "161a381a-d405-4f56-91e1-1c191fa64cd0", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d501167d-849b-463f-9859-fe8532b9dad1", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEMkayq7yek4SySoA6BbLc/kV+zi2qH+jbYgN6QAqluS7TAIpuu/rh1udT/HEEVUjNA==", null, false, "8da78db5-27ae-4a0b-9679-72445f7aab9e", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 5, 0, 0, 40, 855, DateTimeKind.Local).AddTicks(9722), new DateTime(2021, 12, 5, 0, 0, 40, 858, DateTimeKind.Local).AddTicks(408), "Black", "System" },
                    { 2, "System", new DateTime(2021, 12, 5, 0, 0, 40, 858, DateTimeKind.Local).AddTicks(1540), new DateTime(2021, 12, 5, 0, 0, 40, 858, DateTimeKind.Local).AddTicks(1554), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 5, 0, 0, 40, 859, DateTimeKind.Local).AddTicks(3407), new DateTime(2021, 12, 5, 0, 0, 40, 859, DateTimeKind.Local).AddTicks(3423), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 12, 5, 0, 0, 40, 859, DateTimeKind.Local).AddTicks(3429), new DateTime(2021, 12, 5, 0, 0, 40, 859, DateTimeKind.Local).AddTicks(3432), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 12, 5, 0, 0, 40, 859, DateTimeKind.Local).AddTicks(6230), new DateTime(2021, 12, 5, 0, 0, 40, 859, DateTimeKind.Local).AddTicks(6243), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 12, 5, 0, 0, 40, 859, DateTimeKind.Local).AddTicks(6246), new DateTime(2021, 12, 5, 0, 0, 40, 859, DateTimeKind.Local).AddTicks(6248), "X5", "System" },
                    { 3, "System", new DateTime(2021, 12, 5, 0, 0, 40, 859, DateTimeKind.Local).AddTicks(6251), new DateTime(2021, 12, 5, 0, 0, 40, 859, DateTimeKind.Local).AddTicks(6253), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 12, 5, 0, 0, 40, 859, DateTimeKind.Local).AddTicks(6255), new DateTime(2021, 12, 5, 0, 0, 40, 859, DateTimeKind.Local).AddTicks(6257), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "42cf9b25-55d0-436d-b7aa-01e02a24ac3e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "7aa235c6-4a49-4cbc-8d9e-701ccfc4000e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c72fefb3-e4c0-456d-91ee-05f066322e09", "AQAAAAEAACcQAAAAELwcZ5iwtcGFEyeE+K/ZBUfUQOZ+gbZalAKGssq43UYD7/Z60It4gM4Sa1X64rhktA==", "ac5e2952-de07-417d-b381-fe4471fdc243" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 10, 16, 54, 755, DateTimeKind.Local).AddTicks(9464), new DateTime(2022, 1, 12, 10, 16, 54, 757, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 10, 16, 54, 757, DateTimeKind.Local).AddTicks(7606), new DateTime(2022, 1, 12, 10, 16, 54, 757, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 10, 16, 54, 760, DateTimeKind.Local).AddTicks(4314), new DateTime(2022, 1, 12, 10, 16, 54, 760, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 10, 16, 54, 760, DateTimeKind.Local).AddTicks(4352), new DateTime(2022, 1, 12, 10, 16, 54, 760, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 10, 16, 54, 761, DateTimeKind.Local).AddTicks(1659), new DateTime(2022, 1, 12, 10, 16, 54, 761, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 10, 16, 54, 761, DateTimeKind.Local).AddTicks(1685), new DateTime(2022, 1, 12, 10, 16, 54, 761, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 10, 16, 54, 761, DateTimeKind.Local).AddTicks(1691), new DateTime(2022, 1, 12, 10, 16, 54, 761, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 10, 16, 54, 761, DateTimeKind.Local).AddTicks(1696), new DateTime(2022, 1, 12, 10, 16, 54, 761, DateTimeKind.Local).AddTicks(1698) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "d89e22ce-22d0-4b28-a9e7-7366cb06d1a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "08d9cdbb-a943-43bf-b873-9caf1da32e28");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1347ef58-8f4a-468d-af45-72b55206debc", "AQAAAAEAACcQAAAAEFyGwJGIRgg0bPfrV/OJPgQuMj9UlYapDvAR2Xc2sqvZst8eWSV4EXgQWeG8Z9zcaQ==", "c155e849-f108-4c4b-baa8-0f4d2c44af3e" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 53, 13, 443, DateTimeKind.Local).AddTicks(1023), new DateTime(2022, 1, 12, 9, 53, 13, 444, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 53, 13, 444, DateTimeKind.Local).AddTicks(4830), new DateTime(2022, 1, 12, 9, 53, 13, 444, DateTimeKind.Local).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 53, 13, 446, DateTimeKind.Local).AddTicks(9140), new DateTime(2022, 1, 12, 9, 53, 13, 446, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 53, 13, 446, DateTimeKind.Local).AddTicks(9180), new DateTime(2022, 1, 12, 9, 53, 13, 446, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 53, 13, 447, DateTimeKind.Local).AddTicks(4411), new DateTime(2022, 1, 12, 9, 53, 13, 447, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 53, 13, 447, DateTimeKind.Local).AddTicks(4430), new DateTime(2022, 1, 12, 9, 53, 13, 447, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 53, 13, 447, DateTimeKind.Local).AddTicks(4434), new DateTime(2022, 1, 12, 9, 53, 13, 447, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 12, 9, 53, 13, 447, DateTimeKind.Local).AddTicks(4438), new DateTime(2022, 1, 12, 9, 53, 13, 447, DateTimeKind.Local).AddTicks(4439) });
        }
    }
}

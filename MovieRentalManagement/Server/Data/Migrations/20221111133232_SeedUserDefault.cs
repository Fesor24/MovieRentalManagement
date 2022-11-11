using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalManagement.Server.Data.Migrations
{
    public partial class SeedUserDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b6d5c03-9c86-43e5-a907-f544080e250e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb220e7b-5961-4a3c-8909-ec6dc457cd5b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3409cb81-4ee3-48e9-bd08-5e89fec60b74", "b52a6b77-e38d-4955-8dcb-93c0986d95fe", "User", "USER" },
                    { "9009pr81-4ee3-48e9-dc08-5e89fec60b74", "c4504db9-9dde-499b-a806-25d33d40b161", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "e3ea85e0-e60d-41e7-994d-883d25d81f8d", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEOYhIfamtHWM3xYsrqQ6gYhYCU1NH9V9kKRce0oqiAkyIli812hA04zxiyFJG76fxA==", null, false, "fe789329-b7bd-4f5a-b0c2-3c2b9aa1c9f0", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(2175), new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(2188), new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(2190), new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(2193), new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(3014), new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(3021), new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(3023), new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(3025), new DateTime(2022, 11, 11, 14, 32, 31, 868, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9009pr81-4ee3-48e9-dc08-5e89fec60b74", "8e445865-a24d-4543-a6c6-9443d048cdb9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3409cb81-4ee3-48e9-bd08-5e89fec60b74");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9009pr81-4ee3-48e9-dc08-5e89fec60b74", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9009pr81-4ee3-48e9-dc08-5e89fec60b74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b6d5c03-9c86-43e5-a907-f544080e250e", "ef337637-b01d-4e11-a790-c95a690b714e", "User", "USER" },
                    { "bb220e7b-5961-4a3c-8909-ec6dc457cd5b", "9dc0be89-520c-4129-8dcd-afe959a10d56", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(7733), new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(7757), new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(7761), new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(7765), new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(8776), new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(8787), new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(8791), new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(8797), new DateTime(2022, 11, 11, 13, 45, 36, 971, DateTimeKind.Local).AddTicks(8798) });
        }
    }
}

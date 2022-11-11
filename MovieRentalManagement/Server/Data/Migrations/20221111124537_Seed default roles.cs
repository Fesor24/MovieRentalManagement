using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalManagement.Server.Data.Migrations
{
    public partial class Seeddefaultroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b6d5c03-9c86-43e5-a907-f544080e250e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb220e7b-5961-4a3c-8909-ec6dc457cd5b");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1534), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1553), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1556), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1558), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1906), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1909), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1912), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1914), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1914) });
        }
    }
}

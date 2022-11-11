using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalManagement.Server.Data.Migrations
{
    public partial class GenreandIndustrydataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1534), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1546), "Action", "System" },
                    { 2, "System", new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1553), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1554), "Drama", "System" },
                    { 3, "System", new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1556), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1557), "Sci-Fi", "System" },
                    { 4, "System", new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1558), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1559), "Romance", "System" }
                });

            migrationBuilder.InsertData(
                table: "Industries",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1906), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1907), "K-drama", "System" },
                    { 2, "System", new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1909), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1910), "Nollywood", "System" },
                    { 3, "System", new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1912), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1912), "Bollywood", "System" },
                    { 4, "System", new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1914), new DateTime(2022, 11, 11, 13, 35, 58, 563, DateTimeKind.Local).AddTicks(1914), "Hollywood", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

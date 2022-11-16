using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalManagement.Server.Data.Migrations
{
    public partial class AddedCustomerValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3409cb81-4ee3-48e9-bd08-5e89fec60b74",
                column: "ConcurrencyStamp",
                value: "da1812c4-fa68-4f9d-9524-85192924452a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9009pr81-4ee3-48e9-dc08-5e89fec60b74",
                column: "ConcurrencyStamp",
                value: "83325788-3f25-47e0-989e-8b54409c43aa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d07c44c0-0942-444d-a38e-bb62ac4e13a7", "AQAAAAEAACcQAAAAEN24h8x/GyrOHTCG5jnUKxBXsk3nBx10JBUlfbdUgTRCEOby9eFWP8JtdhkNn5IhBw==", "e16f39e2-2be7-416c-a698-57287814f54c" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(1952), new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(1965), new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(1967), new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(1970), new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(2381), new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(2392), new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(2394), new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(2396), new DateTime(2022, 11, 16, 15, 10, 34, 744, DateTimeKind.Local).AddTicks(2397) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3409cb81-4ee3-48e9-bd08-5e89fec60b74",
                column: "ConcurrencyStamp",
                value: "5596e1c6-3b7e-41f2-b865-b36cbb93c2ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9009pr81-4ee3-48e9-dc08-5e89fec60b74",
                column: "ConcurrencyStamp",
                value: "a51a97b2-5e93-462a-a32d-5f8628266303");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fbe4284-9d20-4578-b187-f06ba587bad1", "AQAAAAEAACcQAAAAELb8ZvG7rQlApRIAQHo1SYUtBiQNHZ3G762s3i9AeY9QU0pCa97FvGXsiA5QO+v5tQ==", "a2c820c1-6603-4ac2-b1ac-b01f41562a96" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(4180), new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(4196), new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(4198), new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(4200), new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(5194), new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(5209), new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(5217), new DateTime(2022, 11, 16, 14, 45, 29, 1, DateTimeKind.Local).AddTicks(5226) });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalManagement.Server.Data.Migrations
{
    public partial class EditCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3409cb81-4ee3-48e9-bd08-5e89fec60b74",
                column: "ConcurrencyStamp",
                value: "feee0daf-c562-44c2-9dae-6a395c3b7379");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9009pr81-4ee3-48e9-dc08-5e89fec60b74",
                column: "ConcurrencyStamp",
                value: "b4400021-c6f2-4c10-935c-47315b703a4d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b69bdc7a-baf3-4e70-a456-fcc67c60d9b8", "AQAAAAEAACcQAAAAEJN9H8vaA6m6OjNHCdRnGO4VxTYYvVtSZCaEGlaafZK/ScuBnGIv7OXXan5B2HIJuQ==", "046ab599-8933-42a7-bfa7-377678646817" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 14, 8, 36, 1, 224, DateTimeKind.Local).AddTicks(9662), new DateTime(2022, 11, 14, 8, 36, 1, 224, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 14, 8, 36, 1, 224, DateTimeKind.Local).AddTicks(9680), new DateTime(2022, 11, 14, 8, 36, 1, 224, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 14, 8, 36, 1, 224, DateTimeKind.Local).AddTicks(9683), new DateTime(2022, 11, 14, 8, 36, 1, 224, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 14, 8, 36, 1, 224, DateTimeKind.Local).AddTicks(9685), new DateTime(2022, 11, 14, 8, 36, 1, 224, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 14, 8, 36, 1, 225, DateTimeKind.Local).AddTicks(125), new DateTime(2022, 11, 14, 8, 36, 1, 225, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 14, 8, 36, 1, 225, DateTimeKind.Local).AddTicks(135), new DateTime(2022, 11, 14, 8, 36, 1, 225, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 14, 8, 36, 1, 225, DateTimeKind.Local).AddTicks(137), new DateTime(2022, 11, 14, 8, 36, 1, 225, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 14, 8, 36, 1, 225, DateTimeKind.Local).AddTicks(142), new DateTime(2022, 11, 14, 8, 36, 1, 225, DateTimeKind.Local).AddTicks(149) });
        }
    }
}

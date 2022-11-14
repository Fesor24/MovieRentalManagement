using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieRentalManagement.Server.Data.Migrations
{
    public partial class manytoone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Industries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Industries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Industries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Industries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3409cb81-4ee3-48e9-bd08-5e89fec60b74",
                column: "ConcurrencyStamp",
                value: "b52a6b77-e38d-4955-8dcb-93c0986d95fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9009pr81-4ee3-48e9-dc08-5e89fec60b74",
                column: "ConcurrencyStamp",
                value: "c4504db9-9dde-499b-a806-25d33d40b161");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3ea85e0-e60d-41e7-994d-883d25d81f8d", "AQAAAAEAACcQAAAAEOYhIfamtHWM3xYsrqQ6gYhYCU1NH9V9kKRce0oqiAkyIli812hA04zxiyFJG76fxA==", "fe789329-b7bd-4f5a-b0c2-3c2b9aa1c9f0" });

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
        }
    }
}

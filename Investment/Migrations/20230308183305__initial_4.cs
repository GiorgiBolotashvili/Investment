using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Investment.Migrations
{
    public partial class _initial_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyAddress",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyEmail",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyMotto",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyPhone",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3210e1e0-b2c2-11ed-afa1-0242ac120002",
                column: "ConcurrencyStamp",
                value: "51ee3542-1916-4c28-bb29-bd2d20cd9000");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3210e564-b2c2-11ed-afa1-0242ac120002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "508fea4b-8c82-4fca-896b-d2fe92e335e0", "AQAAAAEAACcQAAAAEBRcpAr9aQIwBuTDkFOEMLbS8+qiUBgAlvuf73nMir0BhFdJool+yoQuQg116ZMpYg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3210ebae-b2c2-11ed-afa1-0242ac120002"),
                column: "DateAdded",
                value: new DateTime(2023, 3, 8, 18, 33, 4, 833, DateTimeKind.Utc).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3210ee24-b2c2-11ed-afa1-0242ac120002"),
                column: "DateAdded",
                value: new DateTime(2023, 3, 8, 18, 33, 4, 833, DateTimeKind.Utc).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("59d61ca4-b2c2-11ed-afa1-0242ac120002"),
                column: "DateAdded",
                value: new DateTime(2023, 3, 8, 18, 33, 4, 833, DateTimeKind.Utc).AddTicks(2101));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyAddress",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "CompanyEmail",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "CompanyMotto",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "CompanyPhone",
                table: "TextFields");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3210e1e0-b2c2-11ed-afa1-0242ac120002",
                column: "ConcurrencyStamp",
                value: "5c60dff2-d6a4-4d81-936f-22c024392bdd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3210e564-b2c2-11ed-afa1-0242ac120002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d87e3aea-7ea2-4bfe-9d25-cffb1f98b10a", "AQAAAAEAACcQAAAAEAL4HG8Ixu+hsMMoHGouDT0hhNQgcq+dZPtXteqW8yTSPdt2lDxRaDtJa0x5yJIluA==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3210ebae-b2c2-11ed-afa1-0242ac120002"),
                column: "DateAdded",
                value: new DateTime(2023, 3, 8, 14, 30, 39, 127, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3210ee24-b2c2-11ed-afa1-0242ac120002"),
                column: "DateAdded",
                value: new DateTime(2023, 3, 8, 14, 30, 39, 127, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("59d61ca4-b2c2-11ed-afa1-0242ac120002"),
                column: "DateAdded",
                value: new DateTime(2023, 3, 8, 14, 30, 39, 127, DateTimeKind.Utc).AddTicks(2874));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Investment.Migrations
{
    public partial class _initial_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubtitleGeo",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextGeo",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleGeo",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubtitleGeo",
                table: "ServiceItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TextGeo",
                table: "ServiceItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleGeo",
                table: "ServiceItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "DateAdded", "Text" },
                values: new object[] { new DateTime(2023, 3, 8, 14, 30, 39, 127, DateTimeKind.Utc).AddTicks(1299), "Information about the company's activities" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3210ee24-b2c2-11ed-afa1-0242ac120002"),
                columns: new[] { "DateAdded", "Text" },
                values: new object[] { new DateTime(2023, 3, 8, 14, 30, 39, 127, DateTimeKind.Utc).AddTicks(2843), "Information about the company's activities" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("59d61ca4-b2c2-11ed-afa1-0242ac120002"),
                columns: new[] { "DateAdded", "Text" },
                values: new object[] { new DateTime(2023, 3, 8, 14, 30, 39, 127, DateTimeKind.Utc).AddTicks(2874), "Information about the company's activities" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubtitleGeo",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "TextGeo",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "TitleGeo",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "SubtitleGeo",
                table: "ServiceItems");

            migrationBuilder.DropColumn(
                name: "TextGeo",
                table: "ServiceItems");

            migrationBuilder.DropColumn(
                name: "TitleGeo",
                table: "ServiceItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3210e1e0-b2c2-11ed-afa1-0242ac120002",
                column: "ConcurrencyStamp",
                value: "46bdebae-93e8-4f06-8a42-a1aaaddce380");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3210e564-b2c2-11ed-afa1-0242ac120002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c097074a-b418-4dfe-a575-b6ed83a8ad6c", "AQAAAAEAACcQAAAAECq/PKPAZFbrIqlLPewY0eROp6iwLYsWMxcLryQblFv4qZAonU5gCofKOGHqcO7oww==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3210ebae-b2c2-11ed-afa1-0242ac120002"),
                columns: new[] { "DateAdded", "Text" },
                values: new object[] { new DateTime(2023, 2, 27, 20, 0, 43, 235, DateTimeKind.Utc).AddTicks(9867), "ინფორმაცია კომპანიის საქმიანობის შესახებ" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3210ee24-b2c2-11ed-afa1-0242ac120002"),
                columns: new[] { "DateAdded", "Text" },
                values: new object[] { new DateTime(2023, 2, 27, 20, 0, 43, 236, DateTimeKind.Utc).AddTicks(2231), "ინფორმაცია კომპანიის საქმიანობის შესახებ" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("59d61ca4-b2c2-11ed-afa1-0242ac120002"),
                columns: new[] { "DateAdded", "Text" },
                values: new object[] { new DateTime(2023, 2, 27, 20, 0, 43, 236, DateTimeKind.Utc).AddTicks(2277), "ინფორმაცია კომპანიის საქმიანობის შესახებ" });
        }
    }
}

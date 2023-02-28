using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Investment.Migrations
{
    public partial class _initial_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFavorit",
                table: "TextFields",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFavorit",
                table: "ServiceItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFavorit",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "IsFavorit",
                table: "ServiceItems");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3210e1e0-b2c2-11ed-afa1-0242ac120002",
                column: "ConcurrencyStamp",
                value: "139351a8-01ca-4497-928e-a526df61d318");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3210e564-b2c2-11ed-afa1-0242ac120002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "285fa6c7-fa61-46b4-95f0-82225255608b", "AQAAAAEAACcQAAAAEN9JgxAJmkgYTdgSAJyOmSPzB2qKHI51bEbwuOQcyQaAiwnSexV9dWmAm5C0fQZIrg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3210ebae-b2c2-11ed-afa1-0242ac120002"),
                columns: new[] { "DateAdded", "Text" },
                values: new object[] { new DateTime(2023, 2, 26, 21, 59, 13, 113, DateTimeKind.Utc).AddTicks(4411), "ივსება ადმინისტრატორის მიერ" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3210ee24-b2c2-11ed-afa1-0242ac120002"),
                columns: new[] { "DateAdded", "Text" },
                values: new object[] { new DateTime(2023, 2, 26, 21, 59, 13, 113, DateTimeKind.Utc).AddTicks(6092), "ივსება ადმინისტრატორის მიერ" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("59d61ca4-b2c2-11ed-afa1-0242ac120002"),
                columns: new[] { "DateAdded", "Text" },
                values: new object[] { new DateTime(2023, 2, 26, 21, 59, 13, 113, DateTimeKind.Utc).AddTicks(6127), "ივსება ადმინისტრატორის მიერ" });
        }
    }
}

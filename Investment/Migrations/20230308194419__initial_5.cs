using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Investment.Migrations
{
    public partial class _initial_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyAddressGeo",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyMottoGeo",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyNameGeo",
                table: "TextFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3210e1e0-b2c2-11ed-afa1-0242ac120002",
                column: "ConcurrencyStamp",
                value: "0683ed5c-d5d8-4be8-a2e3-d4e37b99713a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3210e564-b2c2-11ed-afa1-0242ac120002",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c630639-6231-4417-800e-de137cd7b6ae", "AQAAAAEAACcQAAAAEJA3UMQXp9DlUxaqSpb8vzJ5H2ogz+v2FPsc/8A1fQP50hxLc1cQtb4Pa7PKWUrBdw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3210ebae-b2c2-11ed-afa1-0242ac120002"),
                column: "DateAdded",
                value: new DateTime(2023, 3, 8, 19, 44, 18, 174, DateTimeKind.Utc).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("3210ee24-b2c2-11ed-afa1-0242ac120002"),
                column: "DateAdded",
                value: new DateTime(2023, 3, 8, 19, 44, 18, 174, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("59d61ca4-b2c2-11ed-afa1-0242ac120002"),
                column: "DateAdded",
                value: new DateTime(2023, 3, 8, 19, 44, 18, 174, DateTimeKind.Utc).AddTicks(6652));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyAddressGeo",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "CompanyMottoGeo",
                table: "TextFields");

            migrationBuilder.DropColumn(
                name: "CompanyNameGeo",
                table: "TextFields");

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
    }
}

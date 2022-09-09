using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagerApplication.Migrations
{
    public partial class AddDataCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "creation_date",
                table: "Task",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 20, 15, 24, 366, DateTimeKind.Local).AddTicks(4122),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2022, 9, 8, 20, 14, 31, 628, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "ID", "description", "name", "time" },
                values: new object[,]
                {
                    { new Guid("c98f14ab-de8c-4883-819b-95de0ea27202"), "", "Family Activities", 30L },
                    { new Guid("c98f14ab-de8c-4883-819b-95de0ea27219"), "", "Developer Activities", 40L },
                    { new Guid("c98f14ab-de8c-4883-819b-95de0ea27222"), "", "Home Activities", 80L },
                    { new Guid("c98f14ab-de8c-4883-819b-95de0ea27230"), "", "Artistic Activities", 15L },
                    { new Guid("c98f14ab-de8c-4883-819b-95de0ea2729e"), "", "Pending Activities", 20L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: new Guid("c98f14ab-de8c-4883-819b-95de0ea27202"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: new Guid("c98f14ab-de8c-4883-819b-95de0ea27219"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: new Guid("c98f14ab-de8c-4883-819b-95de0ea27222"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: new Guid("c98f14ab-de8c-4883-819b-95de0ea27230"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "ID",
                keyValue: new Guid("c98f14ab-de8c-4883-819b-95de0ea2729e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "creation_date",
                table: "Task",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 20, 14, 31, 628, DateTimeKind.Local).AddTicks(8481),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2022, 9, 8, 20, 15, 24, 366, DateTimeKind.Local).AddTicks(4122));
        }
    }
}

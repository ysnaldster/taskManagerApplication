using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagerApplication.Migrations
{
    public partial class AddDataTasksAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "creation_date",
                table: "Task",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 20, 18, 49, 623, DateTimeKind.Local).AddTicks(4560),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2022, 9, 8, 20, 15, 24, 366, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "ID", "author", "CategoryID", "creation_date", "description", "priority", "title" },
                values: new object[,]
                {
                    { new Guid("c98f14ab-de8c-4883-819b-95de0ea27210"), "Ysnaldo", new Guid("c98f14ab-de8c-4883-819b-95de0ea2729e"), new DateTime(2022, 9, 8, 20, 18, 49, 623, DateTimeKind.Local).AddTicks(5374), null, 1, "Pay Public Services" },
                    { new Guid("c98f14ab-de8c-4883-819b-95de0ea27211"), "Marta", new Guid("c98f14ab-de8c-4883-819b-95de0ea27202"), new DateTime(2022, 9, 8, 20, 18, 49, 623, DateTimeKind.Local).AddTicks(5384), null, 0, "Finish movie in Netflix" },
                    { new Guid("c98f14ab-de8c-4883-819b-95de0ea27212"), "Natalia", new Guid("c98f14ab-de8c-4883-819b-95de0ea27219"), new DateTime(2022, 9, 8, 20, 18, 49, 623, DateTimeKind.Local).AddTicks(5388), null, 1, "Make a Java Project" },
                    { new Guid("c98f14ab-de8c-4883-819b-95de0ea27213"), "Marco", new Guid("c98f14ab-de8c-4883-819b-95de0ea27222"), new DateTime(2022, 9, 8, 20, 18, 49, 623, DateTimeKind.Local).AddTicks(5390), null, 2, "Clear the house" },
                    { new Guid("c98f14ab-de8c-4883-819b-95de0ea27214"), "Lucía", new Guid("c98f14ab-de8c-4883-819b-95de0ea27230"), new DateTime(2022, 9, 8, 20, 18, 49, 623, DateTimeKind.Local).AddTicks(5393), null, 0, "Drow a Car" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: new Guid("c98f14ab-de8c-4883-819b-95de0ea27210"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: new Guid("c98f14ab-de8c-4883-819b-95de0ea27211"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: new Guid("c98f14ab-de8c-4883-819b-95de0ea27212"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: new Guid("c98f14ab-de8c-4883-819b-95de0ea27213"));

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "ID",
                keyValue: new Guid("c98f14ab-de8c-4883-819b-95de0ea27214"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "creation_date",
                table: "Task",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 20, 15, 24, 366, DateTimeKind.Local).AddTicks(4122),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2022, 9, 8, 20, 18, 49, 623, DateTimeKind.Local).AddTicks(4560));
        }
    }
}

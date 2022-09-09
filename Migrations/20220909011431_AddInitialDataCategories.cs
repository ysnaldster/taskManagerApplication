using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagerApplication.Migrations
{
    public partial class AddInitialDataCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "creation_date",
                table: "Task",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 20, 14, 31, 628, DateTimeKind.Local).AddTicks(8481),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2022, 9, 8, 20, 13, 33, 738, DateTimeKind.Local).AddTicks(1597));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "creation_date",
                table: "Task",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 9, 8, 20, 13, 33, 738, DateTimeKind.Local).AddTicks(1597),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldDefaultValue: new DateTime(2022, 9, 8, 20, 14, 31, 628, DateTimeKind.Local).AddTicks(8481));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicTracker.Migrations
{
    /// <inheritdoc />
    public partial class AddingNewParametersToModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeOnly>(
                name: "EntryTime",
                table: "QuoteEntry",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "DailyCounter",
                table: "QuoteEntry",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateOnly>(
                name: "EntryDate",
                table: "QuoteEntry",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DailyCounter",
                table: "QuoteEntry");

            migrationBuilder.DropColumn(
                name: "EntryDate",
                table: "QuoteEntry");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EntryTime",
                table: "QuoteEntry",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time");
        }
    }
}

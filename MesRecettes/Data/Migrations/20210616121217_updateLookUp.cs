using Microsoft.EntityFrameworkCore.Migrations;

namespace MesRecettes.Data.Migrations
{
    public partial class updateLookUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MeasurementType",
                table: "UnitsOfMeasures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "BakeTemperature",
                table: "Recipes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BackTime",
                table: "Recipes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MeasurementType",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MeasurementType",
                table: "UnitsOfMeasures");

            migrationBuilder.DropColumn(
                name: "MeasurementType",
                table: "Recipes");

            migrationBuilder.AlterColumn<int>(
                name: "BakeTemperature",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BackTime",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}

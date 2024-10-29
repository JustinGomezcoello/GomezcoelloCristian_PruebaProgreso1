using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GomezcoelloCristian_PruebaProgreso1.Migrations
{
    /// <inheritdoc />
    public partial class MigracionInicial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DireccionDate",
                table: "Gomezcoello",
                newName: "Fecha");

            migrationBuilder.AlterColumn<int>(
                name: "Edad",
                table: "Gomezcoello",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<double>(
                name: "Salario",
                table: "Gomezcoello",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salario",
                table: "Gomezcoello");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Gomezcoello",
                newName: "DireccionDate");

            migrationBuilder.AlterColumn<double>(
                name: "Edad",
                table: "Gomezcoello",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}

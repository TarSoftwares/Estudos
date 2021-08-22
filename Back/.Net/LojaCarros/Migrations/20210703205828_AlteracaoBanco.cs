using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaCarros.Migrations
{
    public partial class AlteracaoBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Marcas",
                newName: "MarcaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Carros",
                newName: "CarroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MarcaId",
                table: "Marcas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CarroId",
                table: "Carros",
                newName: "Id");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaCarros.Migrations
{
    public partial class CriaçãoClientesAtual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClientesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "Varchar(50)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Telefone = table.Column<string>(type: "Varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClientesId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cestoque.Migrations
{
    public partial class CriandoTabelaCestaTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CestaOneModel",
                table: "CestaOneModel");

            migrationBuilder.RenameTable(
                name: "CestaOneModel",
                newName: "CestaOne");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CestaOne",
                table: "CestaOne",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CestaTwo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Produto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<int>(type: "int", nullable: false),
                    DataDeCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CestaTwo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CestaTwo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CestaOne",
                table: "CestaOne");

            migrationBuilder.RenameTable(
                name: "CestaOne",
                newName: "CestaOneModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CestaOneModel",
                table: "CestaOneModel",
                column: "Id");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tstWellingtonPimenta.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {                   
                    ClienteId = table.Column<Guid>(nullable: false, defaultValueSql: "NEWID()"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Idade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}

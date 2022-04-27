using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace McMovie.Migrations
{
    public partial class InitialCreate : Migration
    {
        /*UnitialCreate.Up: crea la tabla Movie y configura ID como la clave principal*/
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });
        }

        /*UnitialCreate.Down: revierte los cambios de esquema realizado por la migracion Up*/
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}

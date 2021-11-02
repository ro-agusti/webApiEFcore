using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SWMedicos.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    Especialidad = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    NroMatricula = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "Date", nullable: false),
                    Ciudad = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicos");
        }
    }
}

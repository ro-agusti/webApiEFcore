using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiEscuela.Migrations
{
    public partial class alumno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false),
                    Matricula = table.Column<int>(type: "int", nullable: false),
                    Ciudad = table.Column<string>(type: "Varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumnos");
        }
    }
}

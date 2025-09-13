using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDTALLER.Migrations
{
    /// <inheritdoc />
    public partial class AddScoreAndRatedAtToCalificacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Puntuacion",
                table: "Calificaciones",
                newName: "Score");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Calificaciones",
                newName: "RatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Score",
                table: "Calificaciones",
                newName: "Puntuacion");

            migrationBuilder.RenameColumn(
                name: "RatedAt",
                table: "Calificaciones",
                newName: "Fecha");
        }
    }
}

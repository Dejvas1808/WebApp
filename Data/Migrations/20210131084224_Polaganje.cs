using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Data.Migrations
{
    public partial class Polaganje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Polaganje_Profesor_ImeProfId",
                table: "Polaganje");

            migrationBuilder.DropForeignKey(
                name: "FK_Polaganje_Student_ImeStudId",
                table: "Polaganje");

            migrationBuilder.DropForeignKey(
                name: "FK_Polaganje_Predmet_NazivPredId",
                table: "Polaganje");

            migrationBuilder.DropIndex(
                name: "IX_Polaganje_ImeProfId",
                table: "Polaganje");

            migrationBuilder.DropIndex(
                name: "IX_Polaganje_ImeStudId",
                table: "Polaganje");

            migrationBuilder.DropIndex(
                name: "IX_Polaganje_NazivPredId",
                table: "Polaganje");

            migrationBuilder.DropColumn(
                name: "ImeProfId",
                table: "Polaganje");

            migrationBuilder.DropColumn(
                name: "ImeStudId",
                table: "Polaganje");

            migrationBuilder.DropColumn(
                name: "NazivPredId",
                table: "Polaganje");

            migrationBuilder.AddColumn<int>(
                name: "PredmetId",
                table: "Polaganje",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfesorId",
                table: "Polaganje",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Polaganje",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Polaganje_PredmetId",
                table: "Polaganje",
                column: "PredmetId");

            migrationBuilder.CreateIndex(
                name: "IX_Polaganje_ProfesorId",
                table: "Polaganje",
                column: "ProfesorId");

            migrationBuilder.CreateIndex(
                name: "IX_Polaganje_StudentId",
                table: "Polaganje",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Polaganje_Predmet_PredmetId",
                table: "Polaganje",
                column: "PredmetId",
                principalTable: "Predmet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polaganje_Profesor_ProfesorId",
                table: "Polaganje",
                column: "ProfesorId",
                principalTable: "Profesor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polaganje_Student_StudentId",
                table: "Polaganje",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Polaganje_Predmet_PredmetId",
                table: "Polaganje");

            migrationBuilder.DropForeignKey(
                name: "FK_Polaganje_Profesor_ProfesorId",
                table: "Polaganje");

            migrationBuilder.DropForeignKey(
                name: "FK_Polaganje_Student_StudentId",
                table: "Polaganje");

            migrationBuilder.DropIndex(
                name: "IX_Polaganje_PredmetId",
                table: "Polaganje");

            migrationBuilder.DropIndex(
                name: "IX_Polaganje_ProfesorId",
                table: "Polaganje");

            migrationBuilder.DropIndex(
                name: "IX_Polaganje_StudentId",
                table: "Polaganje");

            migrationBuilder.DropColumn(
                name: "PredmetId",
                table: "Polaganje");

            migrationBuilder.DropColumn(
                name: "ProfesorId",
                table: "Polaganje");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Polaganje");

            migrationBuilder.AddColumn<int>(
                name: "ImeProfId",
                table: "Polaganje",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImeStudId",
                table: "Polaganje",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NazivPredId",
                table: "Polaganje",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Polaganje_ImeProfId",
                table: "Polaganje",
                column: "ImeProfId");

            migrationBuilder.CreateIndex(
                name: "IX_Polaganje_ImeStudId",
                table: "Polaganje",
                column: "ImeStudId");

            migrationBuilder.CreateIndex(
                name: "IX_Polaganje_NazivPredId",
                table: "Polaganje",
                column: "NazivPredId");

            migrationBuilder.AddForeignKey(
                name: "FK_Polaganje_Profesor_ImeProfId",
                table: "Polaganje",
                column: "ImeProfId",
                principalTable: "Profesor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polaganje_Student_ImeStudId",
                table: "Polaganje",
                column: "ImeStudId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polaganje_Predmet_NazivPredId",
                table: "Polaganje",
                column: "NazivPredId",
                principalTable: "Predmet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

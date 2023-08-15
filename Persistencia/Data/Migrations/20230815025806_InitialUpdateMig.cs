using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialUpdateMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_matricula_persona_PersonaIdPersona",
                table: "matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_matricula_salon_SalonIdSalon",
                table: "matricula");

            migrationBuilder.RenameColumn(
                name: "IdTipoPersona",
                table: "tipopersona",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdSalon",
                table: "salon",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdPersona",
                table: "persona",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdPais",
                table: "pais",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SalonIdSalon",
                table: "matricula",
                newName: "SalonId");

            migrationBuilder.RenameColumn(
                name: "PersonaIdPersona",
                table: "matricula",
                newName: "PersonaId");

            migrationBuilder.RenameColumn(
                name: "IdMatricula",
                table: "matricula",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_matricula_SalonIdSalon",
                table: "matricula",
                newName: "IX_matricula_SalonId");

            migrationBuilder.RenameIndex(
                name: "IX_matricula_PersonaIdPersona",
                table: "matricula",
                newName: "IX_matricula_PersonaId");

            migrationBuilder.RenameColumn(
                name: "IdGenero",
                table: "genero",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdDep",
                table: "departamento",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdCiudad",
                table: "ciudad",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_matricula_persona_PersonaId",
                table: "matricula",
                column: "PersonaId",
                principalTable: "persona",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_matricula_salon_SalonId",
                table: "matricula",
                column: "SalonId",
                principalTable: "salon",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_matricula_persona_PersonaId",
                table: "matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_matricula_salon_SalonId",
                table: "matricula");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tipopersona",
                newName: "IdTipoPersona");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "salon",
                newName: "IdSalon");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "persona",
                newName: "IdPersona");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "pais",
                newName: "IdPais");

            migrationBuilder.RenameColumn(
                name: "SalonId",
                table: "matricula",
                newName: "SalonIdSalon");

            migrationBuilder.RenameColumn(
                name: "PersonaId",
                table: "matricula",
                newName: "PersonaIdPersona");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "matricula",
                newName: "IdMatricula");

            migrationBuilder.RenameIndex(
                name: "IX_matricula_SalonId",
                table: "matricula",
                newName: "IX_matricula_SalonIdSalon");

            migrationBuilder.RenameIndex(
                name: "IX_matricula_PersonaId",
                table: "matricula",
                newName: "IX_matricula_PersonaIdPersona");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "genero",
                newName: "IdGenero");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "departamento",
                newName: "IdDep");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ciudad",
                newName: "IdCiudad");

            migrationBuilder.AddForeignKey(
                name: "FK_matricula_persona_PersonaIdPersona",
                table: "matricula",
                column: "PersonaIdPersona",
                principalTable: "persona",
                principalColumn: "IdPersona");

            migrationBuilder.AddForeignKey(
                name: "FK_matricula_salon_SalonIdSalon",
                table: "matricula",
                column: "SalonIdSalon",
                principalTable: "salon",
                principalColumn: "IdSalon");
        }
    }
}

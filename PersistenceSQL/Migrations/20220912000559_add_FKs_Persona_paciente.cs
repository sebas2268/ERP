using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.PersistenceSQL.Migrations
{
    public partial class add_FKs_Persona_paciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TblPaciente_nmid_medicotra",
                schema: "General",
                table: "TblPaciente",
                column: "nmid_medicotra");

            migrationBuilder.AddForeignKey(
                name: "FK_TblPaciente_TblPersona_nmid_medicotra",
                schema: "General",
                table: "TblPaciente",
                column: "nmid_medicotra",
                principalSchema: "General",
                principalTable: "TblPersona",
                principalColumn: "nmid",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblPaciente_TblPersona_nmid_persona",
                schema: "General",
                table: "TblPaciente",
                column: "nmid_persona",
                principalSchema: "General",
                principalTable: "TblPersona",
                principalColumn: "nmid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblPaciente_TblPersona_nmid_medicotra",
                schema: "General",
                table: "TblPaciente");

            migrationBuilder.DropForeignKey(
                name: "FK_TblPaciente_TblPersona_nmid_persona",
                schema: "General",
                table: "TblPaciente");

            migrationBuilder.DropIndex(
                name: "IX_TblPaciente_nmid_medicotra",
                schema: "General",
                table: "TblPaciente");
        }
    }
}

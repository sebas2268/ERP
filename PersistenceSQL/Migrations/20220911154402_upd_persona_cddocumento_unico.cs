using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.PersistenceSQL.Migrations
{
    public partial class upd_persona_cddocumento_unico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TblPersona_cddocumento",
                schema: "General",
                table: "TblPersona",
                column: "cddocumento",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblPaciente_nmid_persona",
                schema: "General",
                table: "TblPaciente",
                column: "nmid_persona",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TblPersona_cddocumento",
                schema: "General",
                table: "TblPersona");

            migrationBuilder.DropIndex(
                name: "IX_TblPaciente_nmid_persona",
                schema: "General",
                table: "TblPaciente");
        }
    }
}

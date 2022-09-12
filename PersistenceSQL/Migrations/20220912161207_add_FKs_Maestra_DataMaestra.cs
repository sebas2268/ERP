using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.PersistenceSQL.Migrations
{
    public partial class add_FKs_Maestra_DataMaestra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "Maestranmmaestro",
            //    schema: "Maestra",
            //    table: "TblDataMaestra",
            //    type: "VARCHAR(50)",
            //    nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblDataMaestra_Maestranmmaestro",
                schema: "Maestra",
                table: "TblDataMaestra",
                column: "nmmaestro");

            migrationBuilder.AddForeignKey(
                name: "FK_TblDataMaestra_TblMaestra_Maestranmmaestro",
                schema: "Maestra",
                table: "TblDataMaestra",
                column: "nmmaestro",
                principalSchema: "Maestra",
                principalTable: "TblMaestra",
                principalColumn: "nmmaestro",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblDataMaestra_TblMaestra_Maestranmmaestro",
                schema: "Maestra",
                table: "TblDataMaestra");

            migrationBuilder.DropIndex(
                name: "IX_TblDataMaestra_Maestranmmaestro",
                schema: "Maestra",
                table: "TblDataMaestra");

            migrationBuilder.DropColumn(
                name: "Maestranmmaestro",
                schema: "Maestra",
                table: "TblDataMaestra");
        }
    }
}

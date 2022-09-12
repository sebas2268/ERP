using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.PersistenceSQL.Migrations
{
    public partial class add_TblMaestra_TblDataMaestra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Maestra");

            migrationBuilder.CreateTable(
                name: "TblDataMaestra",
                schema: "Maestra",
                columns: table => new
                {
                    nmdato = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    nmmaestro = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    cddato = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    dsdato = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    cddato1 = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    cddato2 = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    cddato3 = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    feregistro = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    febaja = table.Column<DateTime>(type: "DATETIME", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblDataMaestra", x => x.nmdato);
                });

            migrationBuilder.CreateTable(
                name: "TblMaestra",
                schema: "Maestra",
                columns: table => new
                {
                    nmmaestro = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    cdmaestro = table.Column<string>(type: "VARCHAR(5)", nullable: false),
                    dsmaestro = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    feregistro = table.Column<DateTime>(type: "DATETIME", nullable: true),
                    febaja = table.Column<DateTime>(type: "DATETIME", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblMaestra", x => x.nmmaestro);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblDataMaestra",
                schema: "Maestra");

            migrationBuilder.DropTable(
                name: "TblMaestra",
                schema: "Maestra");
        }
    }
}

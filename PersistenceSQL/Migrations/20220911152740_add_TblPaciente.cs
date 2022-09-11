using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.PersistenceSQL.Migrations
{
    public partial class add_TblPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblPaciente",
                schema: "General",
                columns: table => new
                {
                    nmid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nmid_persona = table.Column<int>(type: "int", nullable: false),
                    nmid_medicotra = table.Column<int>(type: "int", nullable: false),
                    dseps = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    dsarl = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    feregistro = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    febaja = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    cdusuario = table.Column<string>(type: "VARCHAR(150)", nullable: true),
                    dscondicion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPaciente", x => x.nmid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblPaciente",
                schema: "General");
        }
    }
}

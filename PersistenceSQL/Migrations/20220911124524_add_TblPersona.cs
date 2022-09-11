using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.PersistenceSQL.Migrations
{
    public partial class add_TblPersona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "General");

            migrationBuilder.CreateTable(
                name: "TblPersona",
                schema: "General",
                columns: table => new
                {
                    nmid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cddocumento = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    dsnombres = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    dsapellidos = table.Column<string>(type: "VARCHAR(60)", nullable: true),
                    fenacimiento = table.Column<DateTime>(type: "DATE", nullable: false),
                    cdtipo = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    cdgenero = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    feregistro = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    febaja = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    cdusuario = table.Column<string>(type: "VARCHAR(150)", nullable: true),
                    dsdireccion = table.Column<string>(type: "VARCHAR(200)", nullable: true),
                    dsphoto = table.Column<string>(type: "VARCHAR(500)", nullable: true),
                    cdtelfono_fijo = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    cdtelefono_movil = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    dsemail = table.Column<string>(type: "VARCHAR(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPersona", x => x.nmid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblPersona",
                schema: "General");
        }
    }
}

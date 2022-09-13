using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.PersistenceSQL.Migrations
{
    public partial class upd_maestra_dataMaestra_null_notNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "dsmaestro",
                schema: "Maestra",
                table: "TblMaestra",
                type: "VARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");

            migrationBuilder.AlterColumn<string>(
                name: "cdmaestro",
                schema: "Maestra",
                table: "TblMaestra",
                type: "VARCHAR(5)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(5)");

            migrationBuilder.AlterColumn<string>(
                name: "dsdato",
                schema: "Maestra",
                table: "TblDataMaestra",
                type: "VARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");

            migrationBuilder.AlterColumn<string>(
                name: "cddato3",
                schema: "Maestra",
                table: "TblDataMaestra",
                type: "VARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");

            migrationBuilder.AlterColumn<string>(
                name: "cddato2",
                schema: "Maestra",
                table: "TblDataMaestra",
                type: "VARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");

            migrationBuilder.AlterColumn<string>(
                name: "cddato1",
                schema: "Maestra",
                table: "TblDataMaestra",
                type: "VARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");

            migrationBuilder.AlterColumn<string>(
                name: "cddato",
                schema: "Maestra",
                table: "TblDataMaestra",
                type: "VARCHAR(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "dsmaestro",
                schema: "Maestra",
                table: "TblMaestra",
                type: "VARCHAR(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cdmaestro",
                schema: "Maestra",
                table: "TblMaestra",
                type: "VARCHAR(5)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(5)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "dsdato",
                schema: "Maestra",
                table: "TblDataMaestra",
                type: "VARCHAR(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cddato3",
                schema: "Maestra",
                table: "TblDataMaestra",
                type: "VARCHAR(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cddato2",
                schema: "Maestra",
                table: "TblDataMaestra",
                type: "VARCHAR(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cddato1",
                schema: "Maestra",
                table: "TblDataMaestra",
                type: "VARCHAR(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cddato",
                schema: "Maestra",
                table: "TblDataMaestra",
                type: "VARCHAR(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(20)",
                oldNullable: true);
        }
    }
}

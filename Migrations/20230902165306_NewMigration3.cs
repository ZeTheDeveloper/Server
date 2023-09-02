using Microsoft.EntityFrameworkCore.Migrations;

namespace Server.Migrations
{
    public partial class NewMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Banners",
                table: "Banners");

            migrationBuilder.RenameTable(
                name: "Banners",
                newName: "mt_Banners");

            migrationBuilder.AddPrimaryKey(
                name: "PK_mt_Banners",
                table: "mt_Banners",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_mt_Banners",
                table: "mt_Banners");

            migrationBuilder.RenameTable(
                name: "mt_Banners",
                newName: "Banners");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Banners",
                table: "Banners",
                column: "ID");
        }
    }
}

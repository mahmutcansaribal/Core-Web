using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Expreinces",
                table: "Expreinces");

            migrationBuilder.RenameTable(
                name: "Expreinces",
                newName: "Experinces");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Experinces",
                table: "Experinces",
                column: "ExpreinceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Experinces",
                table: "Experinces");

            migrationBuilder.RenameTable(
                name: "Experinces",
                newName: "Expreinces");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expreinces",
                table: "Expreinces",
                column: "ExpreinceID");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Challenge1.Migrations
{
    public partial class PrimerMigra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "Icons",
                newName: "Users",
                newSchema: "Users");

            migrationBuilder.RenameTable(
                name: "Posts",
                schema: "Icons",
                newName: "Posts",
                newSchema: "Users");

            migrationBuilder.RenameTable(
                name: "Comments",
                schema: "Icons",
                newName: "Comments",
                newSchema: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Icons");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "Users",
                newName: "Users",
                newSchema: "Icons");

            migrationBuilder.RenameTable(
                name: "Posts",
                schema: "Users",
                newName: "Posts",
                newSchema: "Icons");

            migrationBuilder.RenameTable(
                name: "Comments",
                schema: "Users",
                newName: "Comments",
                newSchema: "Icons");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dietician.Migrations
{
    public partial class ChefSkeleton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Chef_ChefId",
                table: "Recipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chef",
                table: "Chef");

            migrationBuilder.RenameTable(
                name: "Chef",
                newName: "Chefs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chefs",
                table: "Chefs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Chefs_ChefId",
                table: "Recipe",
                column: "ChefId",
                principalTable: "Chefs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Chefs_ChefId",
                table: "Recipe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chefs",
                table: "Chefs");

            migrationBuilder.RenameTable(
                name: "Chefs",
                newName: "Chef");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chef",
                table: "Chef",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Chef_ChefId",
                table: "Recipe",
                column: "ChefId",
                principalTable: "Chef",
                principalColumn: "Id");
        }
    }
}

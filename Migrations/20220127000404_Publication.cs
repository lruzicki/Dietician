using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dietician.Migrations
{
    public partial class Publication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublicationId",
                table: "Recipe",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PublicationId",
                table: "Chefs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Publication",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publication", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_PublicationId",
                table: "Recipe",
                column: "PublicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Chefs_PublicationId",
                table: "Chefs",
                column: "PublicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chefs_Publication_PublicationId",
                table: "Chefs",
                column: "PublicationId",
                principalTable: "Publication",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Publication_PublicationId",
                table: "Recipe",
                column: "PublicationId",
                principalTable: "Publication",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chefs_Publication_PublicationId",
                table: "Chefs");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Publication_PublicationId",
                table: "Recipe");

            migrationBuilder.DropTable(
                name: "Publication");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_PublicationId",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_Chefs_PublicationId",
                table: "Chefs");

            migrationBuilder.DropColumn(
                name: "PublicationId",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "PublicationId",
                table: "Chefs");
        }
    }
}

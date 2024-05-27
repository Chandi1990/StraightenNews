using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Straighten.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImagesUrls_News_NewsId",
                table: "ImagesUrls");

            migrationBuilder.DropForeignKey(
                name: "FK_Paragraphs_News_NewsId",
                table: "Paragraphs");

            migrationBuilder.DropForeignKey(
                name: "FK_SubHeadings_News_NewsId",
                table: "SubHeadings");

            migrationBuilder.DropIndex(
                name: "IX_SubHeadings_NewsId",
                table: "SubHeadings");

            migrationBuilder.DropIndex(
                name: "IX_Paragraphs_NewsId",
                table: "Paragraphs");

            migrationBuilder.DropIndex(
                name: "IX_ImagesUrls_NewsId",
                table: "ImagesUrls");

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "SubHeadings");

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "Paragraphs");

            migrationBuilder.DropColumn(
                name: "NewsId",
                table: "ImagesUrls");

            migrationBuilder.AddColumn<string>(
                name: "ImagesIdUrls",
                table: "News",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParagraphIdList",
                table: "News",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubHeadingIdList",
                table: "News",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagesIdUrls",
                table: "News");

            migrationBuilder.DropColumn(
                name: "ParagraphIdList",
                table: "News");

            migrationBuilder.DropColumn(
                name: "SubHeadingIdList",
                table: "News");

            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "SubHeadings",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "Paragraphs",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NewsId",
                table: "ImagesUrls",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubHeadings_NewsId",
                table: "SubHeadings",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Paragraphs_NewsId",
                table: "Paragraphs",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagesUrls_NewsId",
                table: "ImagesUrls",
                column: "NewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImagesUrls_News_NewsId",
                table: "ImagesUrls",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paragraphs_News_NewsId",
                table: "Paragraphs",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubHeadings_News_NewsId",
                table: "SubHeadings",
                column: "NewsId",
                principalTable: "News",
                principalColumn: "Id");
        }
    }
}

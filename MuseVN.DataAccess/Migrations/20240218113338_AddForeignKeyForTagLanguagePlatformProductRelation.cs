using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MuseVN.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyForTagLanguagePlatformProductRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GameTags",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Platform",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SupportedLanguage",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Tags",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "PlatformId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SupportedLangId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    English = table.Column<bool>(type: "bit", nullable: false),
                    SimplifiedChinese = table.Column<bool>(type: "bit", nullable: false),
                    TraditionalChinese = table.Column<bool>(type: "bit", nullable: false),
                    Tagalog = table.Column<bool>(type: "bit", nullable: false),
                    Spanish = table.Column<bool>(type: "bit", nullable: false),
                    Japanese = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Linux = table.Column<bool>(type: "bit", nullable: false),
                    Mac = table.Column<bool>(type: "bit", nullable: false),
                    Windows = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "English", "Japanese", "SimplifiedChinese", "Spanish", "Tagalog", "TraditionalChinese" },
                values: new object[,]
                {
                    { 1, true, true, false, false, false, false },
                    { 2, true, true, false, false, false, false },
                    { 3, true, true, false, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Linux", "Mac", "Windows" },
                values: new object[,]
                {
                    { 1, false, false, true },
                    { 2, false, false, true },
                    { 3, false, false, true }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PlatformId", "Price", "SupportedLangId", "TagId" },
                values: new object[] { 1, 499.0, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PlatformId", "Price", "SupportedLangId", "TagId" },
                values: new object[] { 2, 999.0, 2, 2 });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Action", "Comedy", "Drama", "Educational", "Fantasy", "Horror", "Mystery", "NSFW", "Romance", "ScienceFiction", "SliceOfLife" },
                values: new object[] { 3, false, false, true, false, false, false, true, false, true, true, false });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Date", "Description", "Developer", "PlatformId", "Price", "SupportedLangId", "TagId", "Title" },
                values: new object[] { 3, new DateOnly(2016, 3, 31), "-Decide The Fate Of All Mankind-\r\nCAN YOU CHANGE THE COURSE OF FATE?\r\nAND SAVE THE ONES CLOSEST TO YOU?\r\n\r\nSteins;Gate follows a rag-tag band of tech-savvy young students who discover the means of changing the past via mail, using a modified microwave. Their experiments into how far they can go with their discovery begin to spiral out of control as they become entangled in a conspiracy surrounding SERN, the organisation behind the Large Hadron Collider, and John Titor who claims to be from a dystopian future.", "Nitro Origin", 3, 749.0, 3, 3, "Steins:Gate" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_PlatformId",
                table: "Products",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupportedLangId",
                table: "Products",
                column: "SupportedLangId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TagId",
                table: "Products",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Languages_SupportedLangId",
                table: "Products",
                column: "SupportedLangId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Platforms_PlatformId",
                table: "Products",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Tags_TagId",
                table: "Products",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Languages_SupportedLangId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Platforms_PlatformId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Tags_TagId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropIndex(
                name: "IX_Products_PlatformId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SupportedLangId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_TagId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "PlatformId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SupportedLangId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tags",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "GameTags",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Platform",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SupportedLanguage",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GameTags", "Platform", "Price", "SupportedLanguage" },
                values: new object[] { "[\"Fantasy\",\"Horror\",\"Romance\",\"NSFW\"]", "[\"Windows\"]", 550.0, "[\"English\"]" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GameTags", "Platform", "Price", "SupportedLanguage" },
                values: new object[] { "[\"Drama\",\"Romance\",\"Slice of Life\",\"NSFW\"]", "[\"Windows\"]", 1100.0, "[\"English\"]" });
        }
    }
}

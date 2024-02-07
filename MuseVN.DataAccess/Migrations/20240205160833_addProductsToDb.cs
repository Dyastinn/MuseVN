using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MuseVN.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Developer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    GameTags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Platform = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupportedLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Date", "Description", "Developer", "GameTags", "Platform", "Price", "SupportedLanguage", "Title" },
                values: new object[,]
                {
                    { 1, new DateOnly(2013, 5, 5), "The story centers around Fuminori Sakisaka, a medical school student involved in a vehicle accident that claimed the lives of both his parents and left him with critical injuries.\r\nHe was rescued by experimental brain surgery that coincidentally altered his perception of the world dramatically.\r\n\r\nEverything now seems to be composed of slimy intestines and gore to him. In addition, the rest of his senses: touch, hearing, smell, and taste, are also impaired, similar to his sight, further damaging his mental health.\r\n\r\nFuminori's desire to live dwindles, and one night, while still in the hospital, he contemplates suicide. However, a girl in a white dress named Saya appears before him. Compared to the horrible surroundings, she looks completely normal, if not downright gorgeous. Fuminori soon falls in love with Saya, and she becomes his raison d'être.\r\n\r\nAs time passes, Fuminori gets increasingly secluded from the rest of his normal life as he embarks on a mission to find a specific person Saya is looking for. Fuminori's friends and doctor get more concerned as he acts strangely over time. Nonetheless, they will soon cross paths, for better or worse...", "Nitro Plus", "[\"Fantasy\",\"Horror\",\"Romance\",\"NSFW\"]", "[\"Windows\"]", 550.0, "[\"English\"]", "Saya no Uta" },
                    { 2, new DateOnly(2012, 6, 28), "In the school the three people met. Their relation had been changed in the season, and turned into three love stories.\r\n\r\nMakoto has been admiring a girl he has seen on the train. That girl is Kotonoha Katsura, and he even managed to take a photo of her with his cell phone. Due to new seating in his class, he ends up next to Sekai Saionji, a nosy, but sweet and sincere girl. As she snoops for his cell phone while talking to him, she discovers his crush and vows to help him until Kotonoha agrees to go out with him. When Sekai finally gets them together, she realizes her own feelings after finding out that the person Kotonoha liked was, in fact, Makoto. While waiting for her train next to Makoto, who was waiting for Kotonoha, she has him talking about how he can repay her for all of her help. Before leaving for her train, she kisses him and cries when she boards the way home. Kotonoha happily arrives for her date with Makoto shortly after. With all three main characters carrying different expressions on their faces, the story begins.", "Overflow", "[\"Drama\",\"Romance\",\"Slice of Life\",\"NSFW\"]", "[\"Windows\"]", 1100.0, "[\"English\"]", "School Days" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}

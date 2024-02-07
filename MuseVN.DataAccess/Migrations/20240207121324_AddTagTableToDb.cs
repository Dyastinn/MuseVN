using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MuseVN.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddTagTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<bool>(type: "bit", nullable: false),
                    Comedy = table.Column<bool>(type: "bit", nullable: false),
                    Drama = table.Column<bool>(type: "bit", nullable: false),
                    Educational = table.Column<bool>(type: "bit", nullable: false),
                    Fantasy = table.Column<bool>(type: "bit", nullable: false),
                    Horror = table.Column<bool>(type: "bit", nullable: false),
                    Mystery = table.Column<bool>(type: "bit", nullable: false),
                    Romance = table.Column<bool>(type: "bit", nullable: false),
                    ScienceFiction = table.Column<bool>(type: "bit", nullable: false),
                    NSFW = table.Column<bool>(type: "bit", nullable: false),
                    SliceOfLife = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.id);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "SupportedLanguage",
                value: "[\"English\"]");

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "id", "Action", "Comedy", "Drama", "Educational", "Fantasy", "Horror", "Mystery", "NSFW", "Romance", "ScienceFiction", "SliceOfLife" },
                values: new object[,]
                {
                    { 1, false, false, false, false, true, true, false, true, true, false, false },
                    { 2, false, false, true, false, false, false, false, true, true, false, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "SupportedLanguage",
                value: "[\"english\"]");
        }
    }
}

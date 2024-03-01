using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MuseVN.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLanguageTagPlatformDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Linux",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "Mac",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "Windows",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "English",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "Japanese",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "SimplifiedChinese",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "Spanish",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "Tagalog",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "TraditionalChinese",
                table: "Languages");

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "Platforms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Platforms",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "Languages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Languages",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 1, "English" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 2, "Simplified Chinese" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 3, "Traditional Chinese" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 4, 4, "Tagalog" },
                    { 5, 5, "Spanish" },
                    { 6, 6, "Japanese" }
                });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 1, "Linux" });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 2, "Mac" });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 3, "Windows" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Languages");

            migrationBuilder.AddColumn<bool>(
                name: "Linux",
                table: "Platforms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Mac",
                table: "Platforms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Windows",
                table: "Platforms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "English",
                table: "Languages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Japanese",
                table: "Languages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SimplifiedChinese",
                table: "Languages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Spanish",
                table: "Languages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Tagalog",
                table: "Languages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TraditionalChinese",
                table: "Languages",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "English", "Japanese", "SimplifiedChinese", "Spanish", "Tagalog", "TraditionalChinese" },
                values: new object[] { true, true, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "English", "Japanese", "SimplifiedChinese", "Spanish", "Tagalog", "TraditionalChinese" },
                values: new object[] { true, true, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "English", "Japanese", "SimplifiedChinese", "Spanish", "Tagalog", "TraditionalChinese" },
                values: new object[] { true, true, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Linux", "Mac", "Windows" },
                values: new object[] { false, false, true });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Linux", "Mac", "Windows" },
                values: new object[] { false, false, true });

            migrationBuilder.UpdateData(
                table: "Platforms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Linux", "Mac", "Windows" },
                values: new object[] { false, false, true });
        }
    }
}

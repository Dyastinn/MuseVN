using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MuseVN.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Action",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Comedy",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Drama",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Educational",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Fantasy",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Horror",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Mystery",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "NSFW",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Romance",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "ScienceFiction",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "SliceOfLife",
                table: "Tags");

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "Tags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tags",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 1, "Action" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DisplayOrder", "Name" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 4, 4, "Educational" },
                    { 5, 5, "Fantasy" },
                    { 6, 6, "Horror" },
                    { 7, 7, "Mystery" },
                    { 8, 8, "Romance" },
                    { 9, 9, "Science Fiction" },
                    { 10, 10, "NSFW" },
                    { 11, 11, "Slife of Life" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Tags");

            migrationBuilder.AddColumn<bool>(
                name: "Action",
                table: "Tags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Comedy",
                table: "Tags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Drama",
                table: "Tags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Educational",
                table: "Tags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Fantasy",
                table: "Tags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Horror",
                table: "Tags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Mystery",
                table: "Tags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NSFW",
                table: "Tags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Romance",
                table: "Tags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ScienceFiction",
                table: "Tags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SliceOfLife",
                table: "Tags",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Action", "Comedy", "Drama", "Educational", "Fantasy", "Horror", "Mystery", "NSFW", "Romance", "ScienceFiction", "SliceOfLife" },
                values: new object[] { false, false, false, false, true, true, false, true, true, false, false });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Action", "Comedy", "Drama", "Educational", "Fantasy", "Horror", "Mystery", "NSFW", "Romance", "ScienceFiction", "SliceOfLife" },
                values: new object[] { false, false, true, false, false, false, false, true, true, false, true });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Action", "Comedy", "Drama", "Educational", "Fantasy", "Horror", "Mystery", "NSFW", "Romance", "ScienceFiction", "SliceOfLife" },
                values: new object[] { false, false, true, false, false, false, true, false, true, true, false });
        }
    }
}

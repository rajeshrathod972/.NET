using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Authentication.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "079a4f44-e8b1-4274-b0af-c05cc74de024", null, "admin", "admin" },
                    { "173f071e-d6fd-4553-abfd-4d5229d5763f", null, "client", "client" },
                    { "faa0f4e1-c653-4a99-be11-cbeb0ffb3a72", null, "seller", "seller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "079a4f44-e8b1-4274-b0af-c05cc74de024");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "173f071e-d6fd-4553-abfd-4d5229d5763f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "faa0f4e1-c653-4a99-be11-cbeb0ffb3a72");
        }
    }
}

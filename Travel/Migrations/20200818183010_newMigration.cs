using Microsoft.EntityFrameworkCore.Migrations;

namespace travel.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Country", "Description", "Destination", "Rating" },
                values: new object[,]
                {
                    { 16, "USA", "lots of above ground cemetaries", "Yosemite", 1 },
                    { 17, "USA", "lots of above ground cemetaries", "La Brea Tar Pits", 4 },
                    { 18, "USA", "More above ground cemetaries than everywhere else", "New Orleans", 1 },
                    { 19, "Germany", "lots of above ground cemetaries", "Baseball Town", 1 },
                    { 20, "Greece", "lots of above ground cemetaries", "Mykonos", 1 },
                    { 21, "USA", "lots of above ground cemetaries", "Yosemite", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 21);
        }
    }
}

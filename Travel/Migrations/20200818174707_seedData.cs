using Microsoft.EntityFrameworkCore.Migrations;

namespace travel.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Country", "Description", "Destination", "Rating" },
                values: new object[,]
                {
                    { 6, "USA", "lots of above ground cemetaries", "La Brea Tar Pits", 4 },
                    { 7, "USA", "More above ground cemetaries than everywhere else", "New Orleans", 1 },
                    { 8, "Germany", "lots of above ground cemetaries", "Baseball Town", 1 },
                    { 9, "Greece", "lots of above ground cemetaries", "Mykonos", 1 },
                    { 10, "USA", "lots of above ground cemetaries", "Yosemite", 1 },
                    { 11, "USA", "lots of above ground cemetaries", "La Brea Tar Pits", 4 },
                    { 12, "USA", "More above ground cemetaries than everywhere else", "New Orleans", 1 },
                    { 13, "Germany", "lots of above ground cemetaries", "Baseball Town", 1 },
                    { 14, "Greece", "lots of above ground cemetaries", "Mykonos", 1 },
                    { 15, "USA", "lots of above ground cemetaries", "Yosemite", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Reviews",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}

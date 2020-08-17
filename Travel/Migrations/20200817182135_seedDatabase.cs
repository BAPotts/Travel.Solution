using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace travel.Migrations
{
    public partial class seedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Destination = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Country", "Description", "Destination", "Rating" },
                values: new object[,]
                {
                    { 1, "USA", "lots of above ground cemetaries", "La Brea Tar Pits", 4 },
                    { 2, "USA", "More above ground cemetaries than everywhere else", "New Orleans", 1 },
                    { 3, "Germany", "lots of above ground cemetaries", "Baseball Town", 1 },
                    { 4, "Greece", "lots of above ground cemetaries", "Mykonos", 1 },
                    { 5, "USA", "lots of above ground cemetaries", "Yosemite", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}

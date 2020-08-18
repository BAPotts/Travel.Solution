using Microsoft.EntityFrameworkCore;

namespace Travel.Models
{
  public class TravelContext : DbContext
  {
    public TravelContext(DbContextOptions<TravelContext> options) : base(options)
    {
    }
  protected override void OnModelCreating(ModelBuilder builder)
{
  builder.Entity<Review>()
      .HasData(
        new Review { ReviewId = 1, Destination = "La Brea Tar Pits", Country = "USA", Description= "lots of above ground cemetaries", Rating = 4},
        new Review { ReviewId = 2, Destination = "New Orleans", Country = "USA", Description= "More above ground cemetaries than everywhere else", Rating = 1},
        new Review { ReviewId = 3, Destination = "Baseball Town", Country = "Germany", Description= "lots of above ground cemetaries", Rating = 1},
        new Review { ReviewId = 4, Destination = "Mykonos", Country = "Greece", Description= "lots of above ground cemetaries", Rating = 1},
        new Review { ReviewId = 5, Destination = "Yosemite", Country = "USA", Description= "lots of above ground cemetaries", Rating = 1},
        new Review { ReviewId = 6, Destination = "La Brea Tar Pits", Country = "USA", Description= "lots of above ground cemetaries", Rating = 4},
        new Review { ReviewId = 7, Destination = "New Orleans", Country = "USA", Description= "More above ground cemetaries than everywhere else", Rating = 1},
        new Review { ReviewId = 8, Destination = "Baseball Town", Country = "Germany", Description= "lots of above ground cemetaries", Rating = 1},
        new Review { ReviewId = 9, Destination = "Mykonos", Country = "Greece", Description= "lots of above ground cemetaries", Rating = 1},
        new Review { ReviewId = 10, Destination = "Yosemite", Country = "USA", Description= "lots of above ground cemetaries", Rating = 1},
        new Review { ReviewId = 11, Destination = "La Brea Tar Pits", Country = "USA", Description= "lots of above ground cemetaries", Rating = 4},
        new Review { ReviewId = 12, Destination = "New Orleans", Country = "USA", Description= "More above ground cemetaries than everywhere else", Rating = 1},
        new Review { ReviewId = 13, Destination = "Baseball Town", Country = "Germany", Description= "lots of above ground cemetaries", Rating = 1},
        new Review { ReviewId = 14, Destination = "Mykonos", Country = "Greece", Description= "lots of above ground cemetaries", Rating = 1},
        new Review { ReviewId = 15, Destination = "Yosemite", Country = "USA", Description= "lots of above ground cemetaries", Rating = 1},
        new Review { ReviewId = 16, Destination = "Yosemite", Country = "USA", Description= "lots of above ground cemetaries", Rating = 1},
        new Review { ReviewId = 17, Destination = "La Brea Tar Pits", Country = "USA", Description= "lots of above ground cemetaries", Rating = 4},
        new Review { ReviewId = 18, Destination = "New Orleans", Country = "USA", Description= "More above ground cemetaries than everywhere else", Rating = 1},
        new Review { ReviewId = 19, Destination = "Baseball Town", Country = "Germany", Description= "lots of above ground cemetaries", Rating = 1},
        new Review { ReviewId = 20, Destination = "Mykonos", Country = "Greece", Description= "lots of above ground cemetaries", Rating = 1},
        new Review { ReviewId = 21, Destination = "Yosemite", Country = "USA", Description= "lots of above ground cemetaries", Rating = 1}
      );
}
    public DbSet<Review> Reviews { get; set; }
  }
}
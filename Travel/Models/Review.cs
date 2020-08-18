using System.ComponentModel.DataAnnotations;

namespace Travel.Models
{
  public class Review
  { 
    public int ReviewId { get; set; }
    [Required]
    [StringLength(20)]
    public string Destination { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string Country { get; set; }
    [Required]
    [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
    public int? Rating { get; set; }
  }
}
using System.ComponentModel.DataAnnotations;

namespace AnimeWatchList.Models.Models
{
    public class RatingCreate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double Score { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Comment { get; set; }
    }
}

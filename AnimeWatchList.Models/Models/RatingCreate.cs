using AnimeWatchList.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public virtual Anime Anime { get; set; }

        [ForeignKey(nameof(Anime))]
        public int AnimeId { get; set; }
    }
}

using AnimeWatchList.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimeWatchList.Models.Models
{
    public class RatingDetail
    {
        public int Id { get; set; }

        public double Score { get; set; }

        public string Title { get; set; }

        public string Comment { get; set; }

        public virtual Anime? Anime { get; set; }

        [ForeignKey(nameof(Anime))]
        public int AnimeId { get; set; }
    }
}

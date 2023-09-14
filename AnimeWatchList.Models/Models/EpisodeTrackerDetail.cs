using AnimeWatchList.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimeWatchList.Models.Models
{
    public class EpisodeTrackerDetail
    {
        public int Id { get; set; }

        public int TotalEpisodes { get; set; }

        public int CurrentEpisode { get; set; }

        public virtual Anime Anime { get; set; }

        [ForeignKey(nameof(Anime))]
        public int AnimeId { get; set; }
    }
}

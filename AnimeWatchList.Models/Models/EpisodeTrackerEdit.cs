using System.ComponentModel.DataAnnotations;

namespace AnimeWatchList.Models.Models
{
    public class EpisodeTrackerEdit
    {
        [Required]
        public int Id { get; set; }

        public string AnimeName { get; set; }

        public int TotalEpisodes { get; set; }

        public int CurrentEpisode { get; set; }
    }
}

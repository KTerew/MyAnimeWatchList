using System.ComponentModel.DataAnnotations;

namespace AnimeWatchList.Models.Models
{
    public class EpisodeTrackerCreate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int TotalEpisodes { get; set; }

        [Required]
        public int CurrentEpisode { get; set; }

        public int AnimeId { get; set; }

        public string AnimeName { get; set; }
    }
}

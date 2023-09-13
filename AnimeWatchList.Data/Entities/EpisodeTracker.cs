using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimeWatchList.Data.Entities
{
    public class EpisodeTracker
    {
        [Key]
        public int Id { get; set; }

        public int AnimeId { get; set; }

        [ForeignKey(nameof(AnimeId))]
        public virtual Anime Anime { get; set; }

        public string AnimeName { get; set; }
        [Required]
        public int TotalEpisodes { get; set; }
        [Required]
        public int CurrentEpisode { get; set; }
    }
}

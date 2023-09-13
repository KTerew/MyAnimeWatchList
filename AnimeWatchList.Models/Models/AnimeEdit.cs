using System.ComponentModel.DataAnnotations;

namespace AnimeWatchList.Models.Models
{
    public class AnimeEdit
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public string Poster { get; set; }

        [Required]
        public int NumOfSeasons { get; set; }

        [Required]
        public int NumOfEpisodes { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }
    }
}

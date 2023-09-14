namespace AnimeWatchList.Data.Entities
{
    public class Anime
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Poster { get; set; }

        public int NumOfSeasons { get; set; }

        public int NumOfEpisodes { get; set; }

        public DateTime ReleaseDate { get; set; }

        public virtual List<Rating> Ratings { get; set; } = new List<Rating>();

        public double AverageScore
        {
            get
            {
                return Ratings.Count > 0 ? Ratings.Select(r => r.Score).Sum() / Ratings.Count : 0;
            }
        }
    }
}

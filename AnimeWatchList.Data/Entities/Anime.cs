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
    }
}

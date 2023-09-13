using AnimeWatchList.Models.Models;

namespace AnimeWatchList.Services.BusinessLogic.IServices
{
    public interface IAnimeServices
    {
        Task<bool> CreateAnime(AnimeCreate model);
        Task<bool> UpdateAnime(AnimeEdit model);
        Task<bool> DeleteAnime(int id);
        Task<AnimeDetail> GetAnime(int id);
        Task<List<AnimeListItem>> GetAnimes();
    }
}

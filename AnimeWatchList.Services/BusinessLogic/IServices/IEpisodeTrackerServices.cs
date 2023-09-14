using AnimeWatchList.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeWatchList.Services.BusinessLogic.IServices
{
    public interface IEpisodeTrackerServices
    {
        Task<bool> CreateEpisodeTracker(EpisodeTrackerCreate model);
        Task<bool> UpdateEpisodeTotal(EpisodeTrackerEdit model);
        Task<bool> UpdateCurrentEpisode(EpisodeTrackerEdit model);
        Task<bool> DeleteEpisodeTracker(int id);
        Task<EpisodeTrackerDetail> GetEpisodeTracker(int id);
        Task<List<EpisodeTrackerListItem>> GetEpisodeTrackers();
    }
}

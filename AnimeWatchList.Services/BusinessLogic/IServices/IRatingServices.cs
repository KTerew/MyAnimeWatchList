using AnimeWatchList.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeWatchList.Services.BusinessLogic.IServices
{
    public interface IRatingServices
    {
        Task<bool> CreateRating(RatingCreate model);
        Task<bool> UpdateRating(RatingEdit model);
        Task<bool> DeleteRating(int id);
        Task<RatingDetail> GetRating(int id);
        Task<List<RatingListItem>> GetRatings();
    }
}

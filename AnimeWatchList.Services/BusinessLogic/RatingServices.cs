using AnimeWatchList.Data.Data;
using AnimeWatchList.Data.Entities;
using AnimeWatchList.Models.Models;
using AnimeWatchList.Services.BusinessLogic.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AnimeWatchList.Services.BusinessLogic
{
    public class RatingServices : IRatingServices
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public RatingServices(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateRating(RatingCreate model)
        {
            var rating = _mapper.Map<Rating>(model);

            await _context.Ratings.AddAsync(rating);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> DeleteRating(int id)
        {
            var rating = await _context.Ratings.SingleOrDefaultAsync(x => x.Id == id);
            if (rating == null) return false;

            _context.Ratings.Remove(rating);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<RatingDetail> GetRating(int id)
        {
            var rating = await _context.Ratings.Include(r => r.AnimeId).SingleOrDefaultAsync(x => x.Id == id);

            if (rating == null) return new RatingDetail();

            return _mapper.Map<RatingDetail>(rating);
        }

        public async Task<List<RatingListItem>> GetRatings()
        {
            var rating = await _context.Ratings.Include(r => r.AnimeId).ToListAsync();

            return _mapper.Map<List<RatingListItem>>(rating);
        }

        public async Task<bool> UpdateRating(RatingEdit model)
        {
            var rating = await _context.Ratings.SingleOrDefaultAsync(x => x.Id == model.Id);
            if (rating == null) return false;

            rating.Title = model.Title;
            rating.Comment = model.Comment;
            rating.Score = model.Score;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}

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
    public class EpisodeTrackerServices : IEpisodeTrackerServices
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public EpisodeTrackerServices(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateEpisodeTracker(EpisodeTrackerCreate model)
        {
            var episode = _mapper.Map<EpisodeTracker>(model);

            
            await _context.Episodes.AddAsync(episode);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<bool> DeleteEpisodeTracker(int id)
        {
            var episode = await _context.Episodes.SingleOrDefaultAsync(x => x.Id == id);
            if (episode == null) return false;

            _context.Episodes.Remove(episode);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<EpisodeTrackerDetail> GetEpisodeTracker(int id)
        {
            var episode = await _context.Episodes.Include(e => e.Anime).SingleOrDefaultAsync(x => x.Id == id);

            if (episode == null) return new EpisodeTrackerDetail();

            return _mapper.Map<EpisodeTrackerDetail>(episode);
        }

        public async Task<List<EpisodeTrackerListItem>> GetEpisodeTrackers()
        {
            var episodes = await _context.Episodes.Include(a => a.Anime).ToListAsync();

            return _mapper.Map<List<EpisodeTrackerListItem>>(episodes);
        }

        public async Task<bool> UpdateCurrentEpisode(EpisodeTrackerEdit model)
        {
            var episode = await _context.Episodes.SingleOrDefaultAsync(x => x.Id == model.Id);
            if (episode == null) return false;

            episode.CurrentEpisode = model.CurrentEpisode;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateEpisodeTotal(EpisodeTrackerEdit model)
        {
            var episode = await _context.Episodes.SingleOrDefaultAsync(x => x.Id == model.Id);
            if (episode == null) return false;

            episode.TotalEpisodes = model.TotalEpisodes;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}

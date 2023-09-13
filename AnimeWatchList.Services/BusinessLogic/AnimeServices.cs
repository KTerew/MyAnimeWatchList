using AnimeWatchList.Data.Data;
using AnimeWatchList.Data.Entities;
using AnimeWatchList.Models.Models;
using AnimeWatchList.Services.BusinessLogic.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace AnimeWatchList.Services.BusinessLogic
{
    public class AnimeServices : IAnimeServices
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;

        public AnimeServices(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

            /*var userClaims = httpContextAccessor.HttpContext!.User.Identity as ClaimsIdentity;

            var value = userClaims!.Claims.FirstOrDefault();

            _userId = value!.Value;
            if (_userId == null)
            {
                throw new Exception("User is not signed in!");
            }*/
        }

        public async Task<bool> CreateAnime(AnimeCreate model)
        {
            var anime = _mapper.Map<Anime>(model);
            
            await _context.Animes.AddAsync(anime);
            return await _context.SaveChangesAsync() == 1;
            
        }

        public async Task<bool> DeleteAnime(int id)
        {
            var anime = await _context.Animes.SingleOrDefaultAsync(x => x.Id == id);
            if (anime == null) return false;

            _context.Animes.Remove(anime);
            return await _context.SaveChangesAsync() == 1;
        }

        public async Task<AnimeDetail> GetAnime(int id)
        {
            var anime = await _context.Animes.SingleOrDefaultAsync(x => x.Id == id);

            if (anime == null) return new AnimeDetail();

            return _mapper.Map<AnimeDetail>(anime);
        }

        public async Task<List<AnimeListItem>> GetAnimes()
        {
            var anime = await _context.Animes.ToListAsync();

            if (anime == null) return null;

            return _mapper.Map<List<AnimeListItem>>(anime);
        }

        public async Task<bool> UpdateAnime(AnimeEdit model)
        {
            var anime = await _context.Animes.SingleOrDefaultAsync(x => x.Id == model.Id);
            if (anime == null) return false;

            anime.Name = model.Name;
            anime.Description = model.Description;
            anime.Poster = model.Poster;
            anime.NumOfSeasons = model.NumOfSeasons;
            anime.NumOfEpisodes = model.NumOfEpisodes;
            anime.ReleaseDate = model.ReleaseDate;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}

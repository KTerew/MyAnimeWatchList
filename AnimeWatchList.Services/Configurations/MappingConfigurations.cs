using AnimeWatchList.Data.Entities;
using AnimeWatchList.Models.Models;
using AutoMapper;

namespace AnimeWatchList.Services.Configurations
{
    public class MappingConfigurations : Profile
    {
        public MappingConfigurations() 
        {
            CreateMap<Anime, AnimeCreate>().ReverseMap();
            CreateMap<Anime, AnimeEdit>().ReverseMap();
            CreateMap<Anime, AnimeListItem>().ReverseMap();
            CreateMap<Anime, AnimeDetail>().ReverseMap();

            CreateMap<Rating, RatingCreate>().ReverseMap();
            CreateMap<Rating, RatingEdit>().ReverseMap();
            CreateMap<Rating, RatingListItem>().ReverseMap();
            CreateMap<Rating, RatingDetail>().ReverseMap();

            CreateMap<EpisodeTracker, EpisodeTrackerCreate>().ReverseMap();
            CreateMap<EpisodeTracker, EpisodeTrackerDetail>().ReverseMap();
            CreateMap<EpisodeTracker, EpisodeTrackerEdit>().ReverseMap();
            CreateMap<EpisodeTracker, EpisodeTrackerListItem>().ReverseMap();
        }
    }
}

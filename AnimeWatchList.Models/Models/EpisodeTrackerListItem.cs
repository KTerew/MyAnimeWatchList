using AnimeWatchList.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeWatchList.Models.Models
{
    public class EpisodeTrackerListItem
    {
        public int Id { get; set; }

        public string AnimeName { get; set; }

        public int TotalEpisodes { get; set; }

        public int CurrentEpisode { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs.Movie
{
    public class MovieCreateDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }
        public string Language { get; set; } = string.Empty;
        public string? PosterUrl { get; set; }
        public string? TrailerUrl { get; set; }
        public List<int>? GenreIds { get; set; }
        public List<int>? ActorIds { get; set; }
        public List<int>? DirectorIds { get; set; }
    }
}

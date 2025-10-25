using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public int Duration { get; set; } // in minutes
        public string Language { get; set; } = string.Empty; // original language
        public string? PosterUrl { get; set; }
        public string? TrailerUrl { get; set; }
        [Column(TypeName = "decimal(3,1)")]
        public decimal RatingAvg { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();
        public ICollection<MovieActor> MovieActors { get; set; } = new List<MovieActor>();
        public ICollection<MovieDirector> MovieDirectors { get; set; } = new List<MovieDirector>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Watchlist> Watchlist { get; set; } = new List<Watchlist>();
        public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
    }
}

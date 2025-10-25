using Domain.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class User : IdentityUser
    {
        public string? ProfilePicture { get; set; }
        public DateTime JoinDate { get; set; } = DateTime.UtcNow;

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<Watchlist> Watchlist { get; set; } = new List<Watchlist>();
        public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
    }
}

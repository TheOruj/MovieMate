using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Watchlist : BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public DateTime AddedAt { get; set; } = DateTime.UtcNow;
    }
}

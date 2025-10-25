using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Review : BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int Rating { get; set; } // 1–10
        public string? Comment { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

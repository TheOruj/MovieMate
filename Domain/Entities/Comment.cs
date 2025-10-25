using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public string Text { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

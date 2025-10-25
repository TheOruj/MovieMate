using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Actor : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Bio { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? PhotoUrl { get; set; }

        public ICollection<MovieActor> MovieActors { get; set; } = new List<MovieActor>();
    }
}

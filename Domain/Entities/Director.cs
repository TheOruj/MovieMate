using Domain.Common;
using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Director : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Bio { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? PhotoUrl { get; set; }

        public ICollection<MovieDirector> MovieDirectors { get; set; } = new List<MovieDirector>();
    }
}

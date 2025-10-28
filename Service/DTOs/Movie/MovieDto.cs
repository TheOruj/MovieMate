namespace Service.DTOs.Movie
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public int Duration { get; set; }
        public string Language { get; set; } = string.Empty;
        public string? PosterUrl { get; set; }
        public decimal RatingAvg { get; set; }

        public List<string>? Genres { get; set; }
        public List<string>? Actors { get; set; }
        public List<string>? Directors { get; set; }
    }
}

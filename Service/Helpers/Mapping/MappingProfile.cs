using AutoMapper;
using Domain.Entities;
using Service.DTOs.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Helpers.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieDto>()
    .ForMember(dest => dest.Genres, opt => opt.MapFrom(src => src.MovieGenres.Select(mg => mg.Genre.Name)))
    .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => src.MovieActors.Select(ma => ma.Actor.Name)))
    .ForMember(dest => dest.Directors, opt => opt.MapFrom(src => src.MovieDirectors.Select(md => md.Director.Name)));

            CreateMap<MovieCreateDto, Movie>().ReverseMap();
            CreateMap<MovieCreateDto, Movie>().ReverseMap();
        }
    }
}

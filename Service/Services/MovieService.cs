using AutoMapper;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.Extensions.Logging;
using Repository.Respositories.Interfaces;
using Service.DTOs.Movie;
using Service.Helpers.Responses;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class MovieService : IMovieService
    {

        private readonly IMovieRepository _repository;
        private readonly IMapper _mapper;
        private readonly AppDbContext _appdb;
        public MovieService(IMovieRepository repository, IMapper mapper, AppDbContext appdb) 
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _appdb = appdb ?? throw new ArgumentNullException(nameof(appdb));
        }

        public async Task<OperationResponse> CreateAsync(MovieCreateDto dto)
        {
            await _repository.AddAsync(_mapper.Map<Movie>(dto));
            await _repository.SaveChangesAsync();
            return new OperationResponse { StatusCode = 200, Message= "Movie Successfully added" };
        }

        public async Task<IEnumerable<MovieDto>> GetAllAsync() => _mapper.Map<IEnumerable<MovieDto>>(await _repository.GetAllAsync());

        public async Task<MovieDto?> GetByIdAsync(int id)
        {
            return _mapper.Map<MovieDto>(await _repository.GetByIdAsync(id));
        }

        public async Task<OperationResponse> RemoveAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null)
                return new OperationResponse { StatusCode=404,Message="No Movie Found." };

            _repository.Remove(entity);
            await _repository.SaveChangesAsync();
            return new OperationResponse { StatusCode = 200, Message = "Movie Successfully Removed." };
        }
        public async Task<OperationResponse> UpdateAsync(MovieUpdateDto dto)
        {
            var entity = await _repository.GetByIdAsync(dto.Id);
            if (entity == null)
                return new OperationResponse
                {
                    StatusCode = 404,
                    Message = "No Movie Found"
                };

            entity.Title = dto.Title ?? entity.Title;
            entity.Description = dto.Description ?? entity.Description;
            entity.ReleaseYear = dto.ReleaseYear != default ? dto.ReleaseYear : entity.ReleaseYear;
            entity.Duration = dto.Duration != default ? dto.Duration : entity.Duration;
            entity.Language = dto.Language ?? entity.Language;
            entity.PosterUrl = dto.PosterUrl ?? entity.PosterUrl;
            entity.TrailerUrl = dto.TrailerUrl ?? entity.TrailerUrl;
            entity.RatingAvg = dto.RatingAvg != default ? dto.RatingAvg : entity.RatingAvg;

            if (dto.GenreIds != null && dto.GenreIds.Any())
            {
                entity.MovieGenres.Clear();

                foreach (var genreId in dto.GenreIds)
                {
                    entity.MovieGenres.Add(new MovieGenre { MovieId = entity.Id, GenreId = genreId });
                }
            }

            if (dto.ActorIds != null && dto.ActorIds.Any())
            {
                entity.MovieActors.Clear();

                foreach (var actorId in dto.ActorIds)
                {
                    entity.MovieActors.Add(new MovieActor { MovieId = entity.Id, ActorId = actorId });
                }
            }

            if (dto.DirectorIds != null && dto.DirectorIds.Any())
            {
                entity.MovieDirectors.Clear();

                foreach (var directorId in dto.DirectorIds)
                {
                    entity.MovieDirectors.Add(new MovieDirector { MovieId = entity.Id, DirectorId = directorId });
                }
            }

            await _repository.SaveChangesAsync();

            return new OperationResponse
            {
                StatusCode = 200,
                Message = "Movie Successfully Updated."
            };
        }

    }
}

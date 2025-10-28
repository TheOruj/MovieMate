using Service.DTOs.Movie;
using Service.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface IMovieService
    {
        Task<OperationResponse> CreateAsync(MovieCreateDto dto);
        Task<OperationResponse> UpdateAsync(MovieUpdateDto dto);
        Task<OperationResponse> RemoveAsync(int id);
        Task<MovieDto?> GetByIdAsync(int id);
        Task<IEnumerable<MovieDto>> GetAllAsync();
    }
}

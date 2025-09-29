using MovieSearch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearch.Application.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieResponse>> GetAllAsync();
        Task<IEnumerable<MovieResponse>> GetNearAsync(MovieRequest request);
    }
}

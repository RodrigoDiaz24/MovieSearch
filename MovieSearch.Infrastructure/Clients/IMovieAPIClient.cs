using MovieSearch.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearch.Infrastructure.Clients
{
    public interface IMovieApiClient
    {
        Task<IEnumerable<ExternalMovieDTO>> FetchMoviesAsync();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearch.Infrastructure.Models
{
    public class ExternalMovieDTO
    {
        public string? Title { get; set; }
        public int Release_Year { get; set; }
        public string? Production_Company { get; set; }
        public string? Locations { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}

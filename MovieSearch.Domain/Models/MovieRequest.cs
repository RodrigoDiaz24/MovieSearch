using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearch.Domain.Models
{
    public class MovieRequest
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
        public double Radius { get; set; } = 5;
    }
}

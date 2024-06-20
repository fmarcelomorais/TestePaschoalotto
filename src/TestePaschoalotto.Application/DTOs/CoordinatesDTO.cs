using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TestePaschoalotto.Domain.Model;

namespace TestePaschoalotto.Application.DTOs
{
    public class CoordinatesDTO 
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}

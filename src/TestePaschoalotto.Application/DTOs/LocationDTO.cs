using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePaschoalotto.Domain.Model;

namespace TestePaschoalotto.Application.DTOs
{
    public class LocationDTO
    {
        public Street Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Postcode { get; set; }
        public Cordinates Cordinates { get; set; }
        public Timezone Timezone { get; set; }
    }
}

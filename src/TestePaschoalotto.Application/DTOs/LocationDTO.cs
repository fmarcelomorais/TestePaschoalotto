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
        public StreetDTO Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Postcode { get; set; }
        public CoordinatesDTO Coordinates { get; set; }
        public TimezoneDTO Timezone { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TestePaschoalotto.Domain.Model;

namespace TestePaschoalotto.Application.DTOs
{
    public class LocationDTO : IdDTO
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Postcode { get; set; }

        //public Guid StreetId { get; set; } // FK
        // public Guid CodinatesId { get; set; } //FK
        // public Guid TimezoneId { get; set; } //FK
       
        public StreetDTO Street { get; set; }
        public CoordinatesDTO Coordinates { get; set; }
        public TimezoneDTO Timezone { get; set; }
    }
}

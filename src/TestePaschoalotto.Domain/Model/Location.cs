using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePaschoalotto.Domain.Model
{
    public class Location
    {
        public Guid Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Postcode { get; set; }

        public Guid StreetId { get; set; } // FK
        public Guid CodinatesId { get; set; } //FK
        public Guid TimezoneId { get; set; } //FK

        public Street Street { get; set; }
        public Coordinates Coordinates { get; set; }
        public Timezone Timezone { get; set; }


    }
}

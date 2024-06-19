using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePaschoalotto.Domain.Model
{
    public class Location : Entity
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State {  get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string OffSet { get; set; }
        public string Description { get; set; }

    }
}

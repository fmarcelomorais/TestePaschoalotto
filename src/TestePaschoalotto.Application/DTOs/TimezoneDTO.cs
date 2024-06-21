using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePaschoalotto.Domain.Model;

namespace TestePaschoalotto.Application.DTOs
{
    public class TimezoneDTO : IdDTO
    {
        public string Offset { get; set; }
        public string Description { get; set; }
    }
}

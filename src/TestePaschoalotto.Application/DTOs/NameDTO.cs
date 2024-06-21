using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePaschoalotto.Domain.Model;

namespace TestePaschoalotto.Application.DTOs
{
    public class NameDTO : IdDTO
    {
        public string Title { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }
}

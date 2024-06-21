using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePaschoalotto.Domain.Model;

namespace TestePaschoalotto.Application.DTOs
{
    public class PictureDTO : IdDTO
    {
        public string Large { get; set; }
        public string Medium { get; set; }
        public string Thumbnail { get; set; }
    }
}

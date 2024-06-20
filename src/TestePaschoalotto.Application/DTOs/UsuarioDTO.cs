using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePaschoalotto.Domain.Model;

namespace TestePaschoalotto.Application.DTOs
{
    public class UsuarioDTO
    {
        public string Gender { get; set; }
        public NameDTO Name { get; set; }
        public LocationDTO Location { get; set; }
        public string Email { get; set; }
        public LoginDTO Login { get; set; }
        public DobDTO Dob { get; set; }
        public RegisteredDTO Registered { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public IdDTO Id { get; set; }
        public PictureDTO Picture { get; set; }
    }
}

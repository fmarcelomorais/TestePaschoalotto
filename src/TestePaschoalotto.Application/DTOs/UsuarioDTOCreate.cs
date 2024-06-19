using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePaschoalotto.Domain.Model;

namespace TestePaschoalotto.Application.DTOs
{
    public class UsuarioDTOCreate
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateUser { get; set; }
        public int Age { get; set; }

        /*Login*/

        public string Email { get; set; }
        public Guid Uuid { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Md5 { get; set; }
        public string Sha1 { get; set; }
        public string Sha256 { get; set; }
        public DateTime DateLogin { get; set; }
        public int AgeLogin { get; set; }

        /* Contact*/
        public string Phone { get; set; }
        public string Cell { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        /*Location*/
        public string NameLocation { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string OffSet { get; set; }
        public string Description { get; set; }

        /*Naturalization*/
        public string Nat { get; set; }

        /*Picture*/
        public string Large { get; set; }
        public string Medium { get; set; }
        public string Thumbnail { get; set; }


        public Guid ContactId { get; set; }
        public Guid LocationId { get; set; }
        public Guid LoginId { get; set; }
        public Guid NaturalizationId { get; set; }
        public Guid PictureId { get; set; }


    }
}

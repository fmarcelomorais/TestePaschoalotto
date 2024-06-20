using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestePaschoalotto.Domain.Model;

public class Usuario : Entity
{
    public string Gender { get; set; }
    public Name Name { get; set; }
    public Location Location { get; set; }
    public string Email { get; set; }
    public Login Login { get; set; }
    public Dob Dob { get; set; }
    public Registered Registered { get; set; }
    public string Phone { get; set; }
    public string Cell { get; set; }
    public Picture Picture { get; set; }    
    //public Id Id { get; set; }

    public Guid NameId { get; set; }
    public Guid LocationId { get; set; }
    public Guid LoginId { get; set; }
    public Guid DobId { get; set; }
    public Guid RegisteredId { get; set; }
    public Guid PictureId { get; set; }
    public Guid CoordinateId { get; set; }

}

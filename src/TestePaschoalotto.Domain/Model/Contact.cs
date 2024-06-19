using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePaschoalotto.Domain.Model;

public class Contact : Entity
{
    public string Phone { get; set; }
    public string Cell { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePaschoalotto.Domain.Model
{
    public class Dob : Entity
    {
        public DateTime Date { get; set; }
        public int Age { get; set; }
    }
}


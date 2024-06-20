using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePaschoalotto.Domain.Model
{
    public class Name : Entity
    {
       
        public string Title { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }
}

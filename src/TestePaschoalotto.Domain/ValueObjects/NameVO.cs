using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePaschoalotto.Domain.ValueObjects
{
    public class NameVO
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public NameVO(string title, string firstName, string lastName)
        {
            Title = title;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

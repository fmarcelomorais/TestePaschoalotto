using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePaschoalotto.Domain.Model
{
    public class Login : Entity
    {
        public string Email { get; set; }
        public Guid Uuid { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Md5 { get; set; }
        public string Sha1 { get; set; }
        public string Sha256 { get; set; }
        public DateTime Date { get; set; }
        public int Age { get; set; }
    }
}

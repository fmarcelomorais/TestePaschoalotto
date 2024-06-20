using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestePaschoalotto.Domain.Model
{
    public class Identity  : Entity
    {
        public string Name { get; set; }       
        public string Value { get; set; }

    }
}

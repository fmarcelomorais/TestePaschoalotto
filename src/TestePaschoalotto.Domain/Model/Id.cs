using System.ComponentModel.DataAnnotations;

namespace TestePaschoalotto.Domain.Model
{
    public class Id    
    {        
        //public Guid Codigo { get; set; }
        public string Name { get; set; }
        [Key]
        public string Value { get; set; }

    }
}

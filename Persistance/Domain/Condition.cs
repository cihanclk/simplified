using System.ComponentModel.DataAnnotations.Schema;

namespace GPosProduct.Persistance.Domain
{
    [Table("condition")]
    public class Condition
    {
        public int Id { get; set; }
        public string Conditions { get; set; }
        public string ColorCode { get; set; }
    }
}

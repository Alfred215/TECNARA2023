using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Infraestructure.Entities
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public int Saldo { get; set; }
        public Guid PersonId { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
    }
}
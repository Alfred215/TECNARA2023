using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Entities
{
    public class Tratamiento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int Duracion { get; set; }
        public Guid EnfermedadId { get; set; }

        [ForeignKey("EnfermedadId")]
        public virtual Enfermedad Enfermedad { get; set; }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Entities
{
    public class DiagnosticoTratamiento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid DiagnosticoId { get; set; }
        public Guid TratamientoId { get; set; }

        [ForeignKey("DiagnosticoId")]
        public virtual Diagnostico Diagnostico { get; set; }

        [ForeignKey("TratamientoId")]
        public virtual Tratamiento Tratamiento { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Entities
{
    public class Diagnostico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime Fecha { get; set; }
        public Guid MedicoId { get; set; }
        public Guid PacienteId { get; set; }

        [ForeignKey("MedicoId")]
        public virtual Medico Medico { get; set; }

        [ForeignKey("PacienteId")]
        public virtual Paciente Paciente { get; set; }
    }
}

using Infraestructure.Enumerables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Entities
{
    public class Medico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid FuncionId { get; set; }
        public TimeSpan HorasDia { get; set; }
        public Guid PersonaId { get; set; }
        public Guid HospitalId { get; set; }

        [ForeignKey("PersonaId")]
        public virtual Person Persona { get; set; }

        [ForeignKey("HospitalId")]
        public virtual Hospital Hospital { get; set; }

        [ForeignKey("FuncionId")]
        public virtual Funcion Funcion { get; set; }
    }
}

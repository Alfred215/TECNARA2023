﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure.Enumerables;

namespace Infraestructure.Entities
{
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTimeOffset Fecha { get; set; }
        public MotivoPacienteType Motivo { get; set; }
        public Guid PersonaId { get; set; }
        public Guid HospitalId { get; set; }

        [ForeignKey("PersonaId")]
        public virtual Person Persona { get; set; }

        [ForeignKey("HospitalId")]
        public virtual Hospital Hospital { get; set; }
    }
}
﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Entities
{
    public class PacienteEnfermedad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime Fecha { get; set; }
        public Guid PacienteId { get; set; }
        public Guid EnfermedadId { get; set; }

        [ForeignKey("PacienteId")]
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public virtual Paciente Paciente { get; set; }
        [ForeignKey("EnfermedadId")]
        public virtual Enfermedad Enfermedad { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ejercicios.BBDD.Ejercicios.Entidades
{
    public partial class Empresa
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(50)]
        public string Localización { get; set; }
        public int? CantidadEmpleados { get; set; }
        public int? CantidadOficinas { get; set; }
    }
}
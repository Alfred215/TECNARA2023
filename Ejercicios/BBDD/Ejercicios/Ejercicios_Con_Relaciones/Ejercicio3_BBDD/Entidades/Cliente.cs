﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Ejercicios.BBDD.Ejercicios_Con_Relaciones.Ejercicio3_BBDD.Entidades
{
    public partial class Cliente
    {
        public Cliente()
        {
            BankAccount = new HashSet<BankAccount>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Nombre { get; set; }
        [StringLength(50)]
        public string ContraseñaHash { get; set; }

        [InverseProperty("Client")]
        public virtual ICollection<BankAccount> BankAccount { get; set; }
    }
}
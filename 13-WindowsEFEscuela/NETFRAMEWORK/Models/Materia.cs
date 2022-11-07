﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFRAMEWORK.Models
{
    [Table("Materia")]
    public class Materia
    {
        [Key]
        public int MateriaID { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Programa { get; set; }
    }
}
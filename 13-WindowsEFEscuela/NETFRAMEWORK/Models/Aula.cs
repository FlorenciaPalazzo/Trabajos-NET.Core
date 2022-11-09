using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFRAMEWORK.Models
{
    [Table("Aula")]
    public class Aula
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AulaId { get; set; }

        [Required]
        public int Capacidad { get; set; }

        [Required]
        [Column(TypeName ="char")]
        [StringLength(1)]
        public string Codigo { get; set; }

        public int IdProfesor { get; set; }
        public int IdMateria { get; set; }


        #region
       

        [ForeignKey("IdProfesor")]
        public Profesor Profesor { get; set; }

        
        [ForeignKey("IdMateria")]
        public  Materia Materia { get; set; }
        #endregion
    }
}

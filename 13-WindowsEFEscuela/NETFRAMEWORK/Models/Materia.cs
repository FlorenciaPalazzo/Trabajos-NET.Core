using System;
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
        [Key,ForeignKey("Aula")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MateriaId { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Programa { get; set; }
        public int IdProfesor { get; set; }
        public int IdAula { get; set; }


        #region
        [ForeignKey("IdProfesor")]
        public Profesor Profesor { get; set; }

        [ForeignKey("IdAula")]
        public Aula Aula { get; set; }
        #endregion
    }
}

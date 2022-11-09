using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETFRAMEWORK.Models
{
    [Table("Docente")]   
    public class Profesor
    {
        [Key]
        public int ProfesorId { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [Column(TypeName ="varchar")]
        [StringLength (50)] 
        public string Titulo { get; set; }
        public int IdAula { get; set; }

        public List<Alumno> Alumnos { get; set; }
        public List<Materia> Materias { get; set; }


        #region
        [ForeignKey("IdAula")]
        public Aula Aula { get; set; }
        #endregion
    }
}


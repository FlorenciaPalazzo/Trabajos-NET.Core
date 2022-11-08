using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETFRAMEWORK.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        [Key]
        public int AlumnoId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Apellido { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public int IdProfesor { get; set; }
        [ForeignKey("IdProfesor")]
        public Profesor Profesor  { get; set; }
        
    }
}

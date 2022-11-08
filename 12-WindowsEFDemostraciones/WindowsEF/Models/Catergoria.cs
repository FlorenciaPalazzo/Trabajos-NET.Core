using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.Models
{
     [Table("Categoria")]
     public class Categoria
    {
        //EF convensión: Id, ID o CategoriaId  automaticamente es PK
        public int Id { get; set; }

        [Required]//campo obligatorio - DB: NOT NULL
        [Column(TypeName = "varchar")]//tipo de datos de sql server
        [StringLength(50)]//longitud máxima de la cadena 
        public string Nombre { get; set; }

        #region propiedades de navegacion
        public List<Producto> Productos { get; set; }
        #endregion

    }
}

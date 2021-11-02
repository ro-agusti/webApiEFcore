using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiEscuela.Models
{
    public class Profesor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string Apellido { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string Titulo { get; set; }
    }
}

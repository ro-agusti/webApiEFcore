using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiEscuela.Models
{
    public class Alumno
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string Apellido { get; set; }
        public int Matricula { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string Ciudad { get; set; }
    }
}

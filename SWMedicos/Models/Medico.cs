using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWMedicos.Models
{
    public class Medico
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
        [Required]
        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string Especialidad { get; set; }
        [Required]
        public int NroMatricula { get; set; }
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime FechaNacimiento { get; set; }
        [Column(TypeName = "Varchar")]
        [MaxLength(50)]
        public string Ciudad { get; set; }
    }
}

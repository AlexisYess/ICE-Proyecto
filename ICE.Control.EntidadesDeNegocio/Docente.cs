using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Control.EntidadesDeNegocio
{
    public class Docente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nombre es obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 80 Caracteres")]
        public String Nombre { get; set; }
        [Required(ErrorMessage = "Apellido es Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 80 Caracteres")]
        public String Apellido { get; set; }

        [Required(ErrorMessage = "Telefono es Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]
        public String Telefono { get; set; }
        [NotMapped]
        public int Top_Aux { get; set; }
        public List<Matricula> Matricula { get; set; }
    }
}

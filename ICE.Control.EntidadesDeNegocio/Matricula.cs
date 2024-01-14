using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE.Control.EntidadesDeNegocio
{
    public class Matricula
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es Obligatorio")]
        [StringLength(80, ErrorMessage = "Maximo 80 Caracteres")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "Apellido es Obligatorio")]
        [StringLength(80, ErrorMessage = "Maximo 80 Caracteres")]
        public String Apellido { get; set; }

        [Required(ErrorMessage = "Edad es Obligatorio")]
        public int Edad { get; set; }

        [ForeignKey("Docente")]
        //[Required(ErrorMessage = "Docente es Obligatorio")]
        [Display(Name = "Docente")]
        public int IdDocente { get; set; }

        [ForeignKey("Grupo")]
        //[Required(ErrorMessage = "Grupo es Obligatorio")]
        [Display(Name = "Grupo")]
        public int IdGrupo { get; set; }

        [ForeignKey("Curso")]
        //[Required(ErrorMessage = "Curso es Obligatorio")]
        [Display(Name = "Curso")]
        public int IdCurso { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "FechaInicio")]
        public DateTime FechaInicio { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "FechaFinal")]
        public System.DateTime FechaFinal { get; set; }
        //[Required(ErrorMessage = "Estatus es obligatorio")]
        public byte Estatus { get; set; }

        public Docente Docente { get; set; }
        //se ocupara mas adelante
        public Grupo Grupo { get; set; }
        public Curso Curso { get; set; }

        [NotMapped]
        public int Top_Aux { get; set; }
        public List<Calificacion>Calificacion { get; set; }

    }
    public enum Estatus_Alumno
    {
        ACTIVO = 1,
        INACTIVO = 2
    }
}

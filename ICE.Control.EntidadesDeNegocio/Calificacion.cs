using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ICE.Control.EntidadesDeNegocio
{
    public class Calificacion
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Matricula")]
        [Required(ErrorMessage = "Matricula es Obligatorio")]
        [Display(Name = "Matricula")]
        public int IdMatricula { get; set; }

        [Required(ErrorMessage = "Word es obligatorio")]
        public int Word { get; set; }

        [Required(ErrorMessage = "Excel es obligatorio")]
        public int Excel { get; set; }

        [Required(ErrorMessage = "PowerPoint es obligatorio")]
        public int PowerPoint { get; set; }

        [Required(ErrorMessage = "Acces es obligatorio")]
        public int Access { get; set; }

        [Required(ErrorMessage = "Publsher es obligatorio")]
        public int Publisher { get; set; }

        [Required(ErrorMessage = "Corel Draw es obligatorio")]
        public int CorelDraw { get; set; }

        [Required(ErrorMessage = "Photoshop es obligatorio")]
        public int Photoshop { get; set; }

        [Required(ErrorMessage = "Mantenimiento es obligatorio")]
        public int Mantenimiento { get; set; }


        [Required(ErrorMessage = "Redes es obligatorio")]
        public int Redes { get; set; }


        
        public double Promedio { get; set; }

        public Matricula Matricula { get; set; }

        [NotMapped]
        public int Top_Aux { get; set; }


    }
    
}


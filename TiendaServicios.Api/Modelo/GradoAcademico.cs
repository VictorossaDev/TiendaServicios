using System;
using System.Text;
using System.Collections.Generic;
using TiendaServicios.Api.Modelo;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TiendaServicios.Api.Modelo
{
    public class GradoAcademico
    {
       [Key]
       [Column("GradoAcademicoId")]
       public int GradoAcademicoId { get; set; }

        [Required(ErrorMessage = "El NombreGradoAcademico es obligatorio")]
        [Display(Name = "NombreGradoAcademico")]
        [StringLength(200)]
        public string NombreGradoAcademico { get; set; }

        [Required(ErrorMessage = "El CentroAcademico es obligatorio")]
        [Display(Name = "CentroAcademico")]
        [StringLength(200)]
        public string CentroAcademico { get; set; }

        [Display(Name = "FechaGrado")]
        public DateTime? FechaGrado { get; set; }

        [Column("AutorLibroId")]
        public int AutorLibroId { get; set; }

        // Por buena practica entre microservicios
        [Required(ErrorMessage = "El GradoAcademicoGuid es obligatorio")]
        [Display(Name = "GradoAcademicoGuid")]
        public string GradoAcademicoGuid { get; set; }

         public AutorLibro AutorLibro { get; set; }

    }
}


using System;
using System.Text;
using System.Collections.Generic;
using TiendaServicios.Api.Modelo;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TiendaServicios.Api.Modelo
{
    public class AutorLibro
    {
        [Column("AutorLibroId")]
        public int AutorLibroId { get; set; }

        [Required(ErrorMessage = "El NombreAutor es obligatorio")]
        [Display(Name = "NombreAutor")]
        [StringLength(200)]
        public string NombreAutor { get; set; }

        [Required(ErrorMessage = "El ApellidoAutor es obligatorio")]
        [Display(Name = "ApellidoAutor")]
        [StringLength(200)]
        public string ApellidoAutor { get; set; }

        [Display(Name = "FechaNacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        // Por buena practica entre microservicios
        [Required(ErrorMessage = "El AutorLibroGuid es obligatorio")]
        [Display(Name = "AutorLibroGuid")]
        public string AutorLibroGuid { get; set; }

        public ICollection<GradoAcademico> ListaGradoAcademico { get; set; }


    }
}

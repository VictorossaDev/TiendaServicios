using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TiendaServicios.Api.Modelo;

namespace TiendaServicios.Api.Persistencia
{
    // Esta clase sirve para que se debe de agregar a la base de datos fisica mediante la migracion
    public class TiendaServiciosContext : DbContext
    {
        public TiendaServiciosContext(DbContextOptions<TiendaServiciosContext> options) : base(options)
        { }
        //  Propiedad para la creacion de la entidad en base de datos por migracion

        public DbSet<AutorLibro> AutorLibros { get; set; }
        public DbSet<GradoAcademico> GradoAcademicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ModelCret
        }

    }
}



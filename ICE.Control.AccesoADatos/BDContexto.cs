using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ICE.Control.EntidadesDeNegocio;

namespace ICE.Control.AccesoADatos
{
    public class BDContexto : DbContext
    {
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<Docente> Docente { get; set; }
      

        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Calificacion> Calificacion { get; set; }
        public DbSet<Curso> Curso { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=proyectoICE.mssql.somee.com; Initial Catalog=proyectoICE; User Id=ProyectoICE; Pwd=Izalco2024 ");


           // optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=ControlICE;Integrated Security=True");
        }
    }
}
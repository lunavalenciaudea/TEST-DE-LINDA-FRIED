using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DBTestsDeLindaFried : DbContext
    {
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Preguntas> Preguntas { get; set; }
        public DbSet<Sexo> Sexos { get; set; }
        public DbSet<TipoDeDocumento> TipoDeDocumentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder Builder)
        {
            Builder.UseSqlServer(ConfigurationManager.ConnectionStrings["TestLindaFried"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TipoDeDocumento>()
                .HasMany(e => e.Personas)
                .WithOne(e => e.TipoDeDocumento)
                .HasForeignKey(e => e.IdTipoDeDocumento);

            builder.Entity<Sexo>()
                .HasMany(e => e.Personas)
                .WithOne(e => e.Sexo)
                .HasForeignKey(e => e.IdSexo);

            builder.Entity<Ciudad>()
                .HasMany(e => e.Personas)
                .WithOne(e => e.Ciudad)
                .HasForeignKey(e => e.IdCiudad);


            builder.Entity<Departamento>()
                .HasMany(e => e.Ciudades)
                .WithOne(e => e.Departamento)
                .HasForeignKey(e => e.IdDepartamento);

            builder.Entity<Preguntas>()
                .HasMany(e => e.RespuestaPregunta)
                .WithOne(e => e.Preguntas)
                .HasForeignKey(e => e.IdPregunta);

            builder.Entity<Evaluacion>()
                .HasMany(e => e.RespuestasPreguntas)
                .WithOne(e => e.Evaluacion)
                .HasForeignKey(e => e.IdEvaluacion);

            builder.Entity<Personas>()
                .HasMany(e => e.Usuarios)
                .WithOne(e => e.Personas)
                .HasForeignKey(e => e.IdPersona);

            builder.Entity<Personas>()
                .HasMany(e => e.Evaluaciones)
                .WithOne(e => e.Personas)
                .HasForeignKey(e => e.IdPersona);




        }
    }
}

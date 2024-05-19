using System;
using _2024_1C_E_AgendaDeTurnos.Models;
using Microsoft.EntityFrameworkCore;

namespace _2024_1C_E_AgendaDeTurnos.Data
{
	public class AgendaTurnosContext : DbContext
	{
		public AgendaTurnosContext(DbContextOptions options) : base(options)
        {

		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
        }


        public DbSet<Persona> Personas { get; set; }

        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<Profesional> Profesionales { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Formulario> Formularios { get; set; }

        public DbSet<Prestacion> Prestaciones { get; set; }

        public DbSet<Turno> Turnos { get; set; }

        public DbSet<Admin> Admins { get; set; }













    }
}


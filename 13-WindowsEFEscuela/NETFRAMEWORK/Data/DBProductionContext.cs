using NETFRAMEWORK.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFRAMEWORK.Data
{
    public class DBProductionContext:DbContext
    {
        public DBProductionContext():base("keyDBProduction") { }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Profesor> Productos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Aula> Aulas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) =>
             // base.OnModelCreating(modelBuilder);

             modelBuilder.Entity<Aula>().HasOptional(m => m.Materia).WithRequired(a => a.Aula);
            

    }
}

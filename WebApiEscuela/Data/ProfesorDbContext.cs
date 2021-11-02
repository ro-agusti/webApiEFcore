using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WebApiEscuela.Models;

namespace WebApiEscuela.Data
{
    public class ProfesorDbContext:DbContext
    {
        public ProfesorDbContext(DbContextOptions<ProfesorDbContext> options) : base(options) { }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}

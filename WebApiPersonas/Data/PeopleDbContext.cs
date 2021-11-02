using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore; //agregar
using WebApiPersonas.Models;

namespace WebApiPersonas.Data
{
    public class PeopleDbContext:DbContext
    {
        public PeopleDbContext(DbContextOptions<PeopleDbContext> options) : base(options) { }
        public DbSet<Person> People { get; set; }
    }
}

using Domain.Entity.Agregates.Projects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext (DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }  

        public DbSet<Project> Projects { get; set; }

    }
}

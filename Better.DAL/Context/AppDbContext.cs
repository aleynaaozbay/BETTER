using Better.DAL.Mappings;
using Better.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Better.DAL.Context
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext()
            {

            }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder  builder)
        {

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            
        }


    }
}

using Better.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better.DAL.Mappings
{
    public class RecipeMap : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.Property(p => p.Title).HasMaxLength(100);
            builder.Property(p => p.Content).HasMaxLength(1000);

        }
    }
}

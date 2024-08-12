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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("DAA90872-2B2E-474C-A464-4B0009DFBE0B"),
                Name = "İçecek",
                CreatedDate = DateTime.Now,
            },
             new Category
             {
                 Id = Guid.Parse("786214DC-4B54-4438-A673-412A43F62331"),
                 Name = "Atıştırmalık",
                 CreatedDate = DateTime.Now,


             });
        }
    }
}

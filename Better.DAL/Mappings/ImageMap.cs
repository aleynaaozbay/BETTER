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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("C600EF28-DE70-45D8-8689-2ACE26134F37"),
                FileName = "images/testimage",
                FileType = "jpg",
                CreatedDate = DateTime.Now,

            },
            new Image
            {
                Id = Guid.Parse("35BDB1A3-C402-4A7E-910C-5B7B2E79E486"),
                FileName = "images/testimage2",
                FileType = "jpg",
            });
        }
    }
}

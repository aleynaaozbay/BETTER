using Better.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better.DAL.Mappings
{
    
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");



            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("768963E1-6E0A-46C0-A591-86F417E0E488"),
                RoleId = Guid.Parse("94048F81-1998-413F-B345-31F69185EF4F")

            },
            new AppUserRole
            {
                UserId = Guid.Parse("07441D44-BCFF-4FC4-817D-63A8598DA47C"),
                RoleId = Guid.Parse("FD0658BB-36CE-479C-A309-923BF7CC19BA")

            });

        }
    }
}

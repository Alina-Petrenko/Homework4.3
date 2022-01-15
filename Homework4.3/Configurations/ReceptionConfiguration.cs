using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._3.Configurations
{
    class ReceptionConfiguration : IEntityTypeConfiguration<Reception>
    {
        public void Configure(EntityTypeBuilder<Reception> builder)
        {
            builder
                .HasKey(k => k.Id);
            builder
                .HasData(new List<Reception>()
                {
                    new Reception() {PetId = 1, CustomerId = 1 },
                });
        }
    }
}

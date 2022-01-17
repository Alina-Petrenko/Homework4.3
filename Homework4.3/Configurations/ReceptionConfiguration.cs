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

            builder.HasKey(s => new { s.CustomerId, s.PetId });

            builder.HasOne(ss => ss.Pet)
                .WithMany(s => s.Receptions)
                .HasForeignKey(ss => ss.PetId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ss => ss.Customer)
                .WithMany(s => s.Receptions)
                .HasForeignKey(ss => ss.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasData(new List<Reception>()
                {
                    new Reception() {CustomerId = 1, PetId = 1},
                });
        }
    }
}

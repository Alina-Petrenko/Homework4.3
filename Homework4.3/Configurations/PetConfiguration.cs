using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._3
{
    class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder   
                .HasMany(c => c.Customers)
                .WithMany(s => s.Pets)
                .UsingEntity(j => j.ToTable("Reception"));


            builder
                .HasData(new List<Pet>()
                {
                    new Pet() {PetId = 1, Name = "Bonnie", Age = 3, CustomerId = 1, DoctorId = 1 },
            ////        //new Pet() {PetId = 2, Name = "Chloe", Age = 10, CustomerId = new Customer { CustomerId = 2}, DoctorId = new Doctor {DoctorId = 2 } },
            ////        //new Pet() {PetId = 3, Name = "Tomas", Age = 14, CustomerId = new Customer { CustomerId = 2}, DoctorId = new Doctor {DoctorId = 2 } },
            ////        //new Pet() {PetId = 4, Name = "Locki", Age = 2, CustomerId = new Customer { CustomerId = 3}, DoctorId = new Doctor {DoctorId = 1 } },
            ////        //new Pet() {PetId = 5, Name = "Barni", Age = 6, CustomerId = new Customer { CustomerId = 4}, DoctorId = new Doctor {DoctorId = 3 } },
            ////        //new Pet() {PetId = 6, Name = "Lily", Age = 3, CustomerId = new Customer { CustomerId = 5}, DoctorId = new Doctor {DoctorId = 3 } },
            ////        //new Pet() {PetId = 7, Name = "Jake", Age = 5, CustomerId = new Customer { CustomerId = 5}, DoctorId = new Doctor {DoctorId = 1 } },

                });
        }

    }
}

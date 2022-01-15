using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework4._3
{
    class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder
                .HasKey(p => p.DoctorId);

            builder
                .HasData(new List<Doctor>()
                {
                                new Doctor {DoctorId = 1 ,  FirstName = "Alexandr", LastName = "Tetera", Speciality = "Veterynary" },
                    //            //new Doctor { DoctorId = 2, FirstName = "Dora", LastName = "Black", Speciality = "Laboratory" },
                    //            //new Doctor { DoctorId = 3, FirstName = "Mike", LastName = "Jeffertson", Speciality = "Assistant" }
                });

        }
    }
}

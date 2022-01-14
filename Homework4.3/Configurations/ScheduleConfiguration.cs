using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._3
{
    class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder
                .HasNoKey();
            //builder
            //    .HasData(new List<Schedule>(){
            //        new Schedule {Time = new DateTime(2022, 1, 16, 09, 30, 00), DoctorID = new Doctor {DoctorId = 1 }, CustomerId = new Customer { CustomerId = 1} },
            //        new Schedule {Time = new DateTime(2022, 1, 16, 10, 00, 00), DoctorID = new Doctor {DoctorId = 2 }, CustomerId = new Customer { CustomerId = 2} },
            //        new Schedule {Time = new DateTime(2022, 1, 16, 10, 30, 00), DoctorID = new Doctor {DoctorId = 3 }, CustomerId = new Customer { CustomerId = 4} },
            //        new Schedule {Time = new DateTime(2022, 1, 16, 11, 00, 00), DoctorID = new Doctor {DoctorId = 1 }, CustomerId = new Customer { CustomerId = 5} },
            //        new Schedule {Time = new DateTime(2022, 1, 16, 11, 30, 00), DoctorID = new Doctor {DoctorId = 3 }, CustomerId = new Customer { CustomerId = 5} }
            //});
        }
    }
}

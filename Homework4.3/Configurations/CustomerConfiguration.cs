using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework4._3
{
    class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            
            builder
                .HasData(new List<Customer>()
                {
            new Customer() {CustomerId = 1,  FirstName = "Tom", LastName = "Anderson", Email = "" }
            ////        //new Customer() {CustomerId = 2, FirstName = "Anna", LastName = "Gloves", Email = ""  },
            ////        //new Customer() {CustomerId = 3, FirstName = "Antonio", LastName = "Banderas", Email = ""  },
            ////        //new Customer() {CustomerId = 4, FirstName = "Jimmy", LastName = "Halls", Email = ""  },
            ////        //new Customer() {CustomerId = 5, FirstName = "Leonardo", LastName = "Di Caprio", Email = ""  },
                });

        }   
    }
}

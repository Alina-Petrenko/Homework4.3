using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._3
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        //public List<Pet> Pets { get; set; } = new List<Pet>();
        public List<Reception> Receptions { get; set; } = new List<Reception>();

    }
}

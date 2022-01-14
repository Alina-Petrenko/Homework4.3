﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._3
{
    class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Doctor DoctorId { get; set; }
        public Customer CustomerId { get; set; }
        public List<Reception> Receptions { get; set; } = new List<Reception>();
    }
}

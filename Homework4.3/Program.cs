using Homework4._3.Configurations;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace Homework4._3
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = ConfigJson.GetString();
            using (var context = new ApplicationContext(connectionString))
            {
                var petsStart = context.Pets.Where(a => a.Name.StartsWith("B")).ToList();
                foreach (var item in petsStart)
                {
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("");
                var customersSort = context.Customers.OrderBy(a => a.FirstName).ToList();
                foreach (var item in customersSort)
                {
                    Console.WriteLine(item.FirstName);
                }
                Console.WriteLine("");
                var petSumAge = context.Pets.Sum(a => a.Age);
                Console.WriteLine(petSumAge);

            }
        }
    }
}

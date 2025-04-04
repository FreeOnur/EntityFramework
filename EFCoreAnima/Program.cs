using EFCoreAnima;
using System;
using System.Linq;

namespace EFCoreAnima
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                // Adding a new animal
                var animal = new Animal { Name = "Jacky", Age = 12, Colour = "Brown" };
                context.Animals.Add(animal);
                context.SaveChanges();

                // Querying the student
                var query = context.Animals.Where(s => s.Name == "Jacky");

                foreach (var anim in query)
                {
                    Console.WriteLine($"Student: {anim.Name}, Age: {anim.Age}");
                }
            }
        }
    }
}
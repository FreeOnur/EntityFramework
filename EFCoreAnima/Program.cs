using EFCoreAnima;
using EFCoreAnima.Classes;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAnima
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                var tierheim = new Tierheim
                {
                    TierheimName = "Wiener Tierheim",
                    AnimalsList = new List<Animal>()
                };
                context.Tierheime.Add(tierheim);
                context.SaveChanges();

                var animal = new Animal
                {
                    Name = "Jacky",
                    Age = 12,
                    Colour = "Brown",
                    TierheimId = tierheim.Id
                };
                var anotherAnimal = new Animal
                {
                    Name = "Fixy",
                    Age = 12,
                    Colour = "Brown",
                    TierheimId = tierheim.Id
                };
                context.Animals.Add(animal);
                context.Animals.Add(anotherAnimal);
                context.SaveChanges();

                tierheim.AnimalsList.Add(animal);
                tierheim.AnimalsList.Add(anotherAnimal);
                context.SaveChanges();

                var query = context.Animals.Where(s => s.Name == "Jacky");
                foreach (var anim in query)
                {
                    Console.WriteLine($"Animal: {anim.Name}, Age: {anim.Age}");
                }

                var TierheimTest = context.Tierheime
                    .Include(t => t.AnimalsList)
                    .FirstOrDefault(t => t.TierheimName == "Wiener Tierheim");

                if (TierheimTest != null)
                {
                    Console.WriteLine($"Tierheim: {TierheimTest.TierheimName}, Number of Animals: {TierheimTest.AnimalsList.Count}");
                    foreach (var anim in TierheimTest.AnimalsList)
                    {
                        Console.WriteLine($"Animal: {anim.Name}, Age: {anim.Age}, Colour: {anim.Colour}");
                    }
                }
            }
        }
    }
}

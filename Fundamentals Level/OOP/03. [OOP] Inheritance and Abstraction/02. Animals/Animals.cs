using System;
using System.Collections.Generic;
using System.Linq;
using Animals.Animal;

namespace Animals
{
    class Animals
    {
        static void Main()
        {
            List<Animal.Animal> animals = new List<Animal.Animal>()
            {
                new Dog("Sara", 2, "Female"),
                new Dog("Sharo", 4, "Male"),
                new Cat("Spayk", 3, "Male"),
                new Dog("Rex", 7, "Male"),
                new Frog("Hasan", 1, "Male"),
                new Frog("Java", 30, "Male"),
                new Cat("Mercedes", 3, "Female"),
                new Tomcat("Sasho", 4),
                new Tomcat("Nayden", 19),
                new Kitten("Ospina", 2),
            };

            var groupedAnimals = from animal in animals
                group animal by animal.GetType().Name
                into animalGroup
                orderby animalGroup.Average(animal => animal.Age)
                select new { Group = animalGroup, AverageAge = animalGroup.Average(animal => animal.Age) };

            foreach (var groupedAnimal in groupedAnimals)
            {
                Console.WriteLine("{0,-10}: {1,-5:F2}", groupedAnimal.Group.Key, groupedAnimal.AverageAge);
            }


        }
    }
}

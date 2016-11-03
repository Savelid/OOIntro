using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOIntro
{
    class Program
    {
        static List<Animal> animals = new List<Animal>();
        static void Main(string[] args)
        {
            Console.WriteLine(Animal.InstanceCount);

            var duckOne = new Duck("Brown", 2.91);
            var duckTwo = new Duck();

            Console.WriteLine($"color: {duckOne.Color} \t weight: {duckOne.Weight}");
            Console.WriteLine($"color: {duckTwo.Color} \t weight: {duckTwo.Weight}");

            var elephant = new Elephant(2764);
            Console.WriteLine($"color: {elephant.Color} \t weight: {elephant.Weight}");

            animals.Add(duckOne);
            animals.Add(duckTwo);
            animals.Add(elephant);

            PrintOutAllAnimals();

            duckOne.Eat(elephant);

            PrintOutAllAnimals();

            var dog = new Dog();
            dog.Eat(duckOne);
            animals.Add(dog);

            PrintOutAllAnimals();

            foreach (var item in animals)
            {
                Console.WriteLine(item.MakeSound());
            }

            Console.WriteLine(Animal.InstanceCount);

        }

        private static void PrintOutAllAnimals()
        {
            foreach (var item in animals)
            {
                Console.WriteLine($"type {item.GetType()} \t color: {item.Color} \t weight: {item.Weight}");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animals
    {
        public static void Main()
        {
            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            string input = Console.ReadLine();

            while (input != "I'm your Huckleberry")
            {
                string[] tokens = input.Split(' ');
                if (tokens.Length > 2)
                {
                    string animalClass = tokens[0];
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    int parameter = int.Parse(tokens[3]);

                    switch (animalClass)
                    {
                        case "Dog":
                        var newDog = new Dog()
                        {
                            Name = name,
                            Age = age,
                            NumberOfLegs = parameter
                        };

                        dogs.Add(newDog.Name, newDog);
                        break;

                        case "Cat":
                        var newCat = new Cat()
                        {
                            Name = name,
                            Age = age,
                            IQ = parameter
                        };

                        cats.Add(newCat.Name, newCat);
                        break;

                        case "Snake":
                        var newSnake = new Snake()
                        {
                            Name = name,
                            Age = age,
                            Cruelty = parameter
                        };

                        snakes.Add(newSnake.Name, newSnake);
                        break;
                    }                   
                }
                else
                {
                    string animalName = tokens[1];
                    if (dogs.ContainsKey(animalName))
                    {
                        dogs[animalName].ProduceSound();
                    }
                    else if (cats.ContainsKey(animalName))
                    {
                        cats[animalName].ProduceSound();
                    }
                    else
                    {
                        snakes[animalName].ProduceSound();
                    }
                }    
                
                input = Console.ReadLine();
            }

            foreach (var dog in dogs)
            {
                Console.WriteLine("Dog: {0}, Age: {1}, Number of legs: {2}", 
                    dog.Key, dog.Value.Age, dog.Value.NumberOfLegs);
            }

            foreach (var cat in cats)
            {
                Console.WriteLine("Cat: {0}, Age: {1}, IQ: {2}",
                    cat.Key, cat.Value.Age, cat.Value.IQ);
            }

            foreach (var snake in snakes)
            {
                Console.WriteLine("Snake: {0}, Age: {1}, Cruelty: {2}",
                    snake.Key, snake.Value.Age, snake.Value.Cruelty);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a distinguished dog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IntelligenceQuotient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    public class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }
    
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
                string[] parts = input.Split(' ');

                if (parts.Length > 2)
                {
                    string type = parts[0];
                    string name = parts[1];
                    int age = int.Parse(parts[2]);
                    int parameter = int.Parse(parts[3]);

                    switch (type)
                    {
                        case "Dog":
                            Dog newDog = new Dog
                            {
                                Name = name,
                                Age = age,
                                NumberOfLegs = parameter
                            };

                            dogs.Add(newDog.Name, newDog);                            
                            break;

                        case "Cat":
                            Cat newCat = new Cat
                            {
                                Name = name,
                                Age = age,
                                IntelligenceQuotient = parameter
                            };
                            
                            cats.Add(newCat.Name, newCat);
                            break;

                        case "Snake":
                            Snake newSnake = new Snake
                            {
                                Name = name,
                                Age = age,
                                CrueltyCoefficient = parameter
                            };

                            snakes.Add(newSnake.Name, newSnake);
                            break;
                    }
                }
                else
                {
                    string animalName = parts[1];

                    if (dogs.ContainsKey(animalName))
                    {
                        dogs[animalName].ProduceSound();
                    }
                    else if (cats.ContainsKey(animalName))
                    {
                        cats[animalName].ProduceSound();
                    }
                    else if (snakes.ContainsKey(animalName))
                    {
                        snakes[animalName].ProduceSound();
                    }
                }

                input = Console.ReadLine();                
            }

            foreach (var dog in dogs.Values)
            {
                Console.WriteLine("Dog: {0}, Age: {1}, Number Of Legs: {2}", dog.Name, dog.Age, dog.NumberOfLegs);
            }

            foreach (var cat in cats.Values)
            {
                Console.WriteLine("Cat: {0}, Age: {1}, IQ: {2}", cat.Name, cat.Age, cat.IntelligenceQuotient);
            }

            foreach (var snake in snakes.Values)
            {
                Console.WriteLine("Snake: {0}, Age: {1}, Cruelty: {2}", snake.Name, snake.Age, snake.CrueltyCoefficient);
            }
        }
    }
}

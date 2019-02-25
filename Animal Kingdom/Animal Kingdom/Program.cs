using System;
using System.Collections.Generic;
using System.Linq;

namespace Animal_Kingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal hedgehog = new Animal("Luna", "European", "Brown", FoodType.Carnivore);

            Dog myDog = new Dog("Lucky", "Cocker Spaniel", "Black", FoodType.Omnivore);

            Cat yourCat = new Cat("Misty", "Scottish Fold", "Brown", FoodType.Carnivore);
        }
    }
}

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

            //  Move
            hedgehog.Move();
            myDog.Move();
            yourCat.Move();

            //  Speak
            hedgehog.Speak();
            myDog.Speak();
            yourCat.Speak();

            //  Eat
            hedgehog.Eat();
            myDog.Eat();
            yourCat.Eat();

            //  Play
            hedgehog.Play();
            myDog.Play();
            yourCat.Play();
        }
    }
}

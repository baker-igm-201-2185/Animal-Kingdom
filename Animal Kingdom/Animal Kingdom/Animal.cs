using System;

namespace Animal_Kingdom
{
    public enum FoodType
    {
        Carnivore,
        Herbivore,
        Omnivore
    }

    class Animal
    {
        protected string name;
        protected string breed;
        protected string color;
        protected FoodType feedingType;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Breed
        {
            get
            {
                return breed;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
        }

        public FoodType FeedingType
        {
            get
            {
                return feedingType;
            }
        }

        public Animal(string name, string breed, string color, FoodType feedingType)
        {
            this.name = name;
            this.breed = breed;
            this.color = color;
            this.feedingType = feedingType;
        }

        public void Move()
        {
            Console.WriteLine("{0} moves", name);
        }

        public void Eat()
        {
            Console.WriteLine("{0} is a {1}", name, feedingType);
        }

        public void Speak()
        {
            Console.WriteLine("{0} speak", name);
        }

        public void Play()
        {
            Console.WriteLine("{0} plays", name);
        }
    }
}

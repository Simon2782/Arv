namespace Arv
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
        public bool IsEndangered { get; set; }
        public Animal(string name = "Unnamed Animal", int age = 0, double weight = 0, string color = "Unknown", bool isEndangered = false)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Color = color;
            IsEndangered = isEndangered;
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public virtual void Sleep() 
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} is moving.");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }

}

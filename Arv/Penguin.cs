namespace Arv
{
    public class Penguin : Animal
    {
        public bool CanFly { get; set; }

        public Penguin() : base("Penguin", 3, 30, "Black and white", false)
        {
            CanFly = false;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Penguin squawks: SQUAWK!");
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming.");
        }
    }
}

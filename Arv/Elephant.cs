namespace Arv
{
    public class Elephant : Animal
    {
        public double TrunkLength { get; set; }

        public Elephant() : base("Elephant", 10, 5400, "Gray", true)
        {
            TrunkLength = 2.0; 
        }

        public override void MakeSound()
        {
            Console.WriteLine("Elephant trumpets: PAAA!");
        }

        public void UseTrunk()
        {
            Console.WriteLine($"{Name} is using its trunk.");
        }
    }
}

namespace Arv
{
    public class Lion : Animal
    {
        public string ManeColor { get; set; }
        public Lion() : base("Lion", 5, 100, "Golden", false)
        {
            ManeColor = "Dark Golden";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Lion roars: ROAR!");
        }

        public void Hunt()
        {
            Console.WriteLine($"{Name} is hunting");
        }
    }
}

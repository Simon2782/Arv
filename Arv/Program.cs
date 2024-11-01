namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lion = new Lion();
            var elephant = new Elephant();
            var penguin = new Penguin();

            var whitelion = new WhiteLio();
            var barbarylion = new BarbaryLio();

            lion.MakeSound();
            elephant.MakeSound();
            penguin.MakeSound();
            whitelion.MakeSound();
            barbarylion.MakeSound();
        }
    }
}

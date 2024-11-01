namespace Arv
{
    public class WhiteLio : Lion
    {
        public WhiteLio()
        {
            ManeColor = "White";
            Name = "White Lion";
        }

        public override void MakeSound()
        {
            Console.WriteLine("White Lion roars quietly: ROAR.");
        }
    }
}

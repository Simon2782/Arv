namespace Arv
{
    public class BarbaryLio : Lion
    {
        public BarbaryLio()
        {
            ManeColor = "Thick Golden";
            Name = "Barbary Lion";
        }

        public override void MakeSound()
        {
            Console.WriteLine("Barbary Lion roars powerfully: ROAAAR!!!");
        }
    }
}

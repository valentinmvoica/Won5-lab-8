using System;

namespace Won5_lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor m1 = new Motor(1968,76,"gpl");

            Autoturism autoturism = new Autoturism("bmw", "x5", 2001, m1, 5);
            Autoturism autoturism2 = new Autoturism("dacia", "logan", 2023, new Motor(1500,130,"benzina"),5);
            Autoturism autoturism3 = new Autoturism("lada", "niva", 1968, new Motor(1200, 50, "vodka"), 3);

            autoturism.Porneste();
            autoturism.Opreste();

            Console.WriteLine(autoturism.Description);
            Console.WriteLine(autoturism2.Description);
            Console.WriteLine(autoturism3.Description);

            Console.WriteLine(Autoturism.NrTotalAutoturisme);
            if (Autoturism.Bolidul != null)
            {
                Console.WriteLine(Autoturism.Bolidul.Description);
            }

        }
    }
}

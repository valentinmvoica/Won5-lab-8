using System;
using System.Collections.Generic;
using System.Text;

namespace Won5_lab_8
{
    class Autoturism
    {
        #region static stuff         
        private static void InregistreazaAutoturism(Autoturism autoturism)
        {
            NrTotalAutoturisme++;

            if (Bolidul == null || autoturism.motor.Putere > Bolidul.motor.Putere)
            {
                Bolidul = autoturism;
            }
        }
        public static int NrTotalAutoturisme { get; private set; }
        public static Autoturism Bolidul { get; private set; }

        #endregion static stuff

        private readonly string marca;
        private readonly string model;
        private readonly int anFabricatie;
        private readonly Motor motor;
        private Usa[] usi;

        public Autoturism(string marca, string model, int anFabricatie, Motor motor, int nrUsi)
        {
            this.marca = marca;
            this.model = model;
            this.anFabricatie = anFabricatie;
            this.motor = motor;

            usi = new Usa[nrUsi];
            for (var i = 0; i < nrUsi; i++)
            {
                usi[i] = new Usa();
            }

            InregistreazaAutoturism(this);
        }
        public int Putere { get { return this.motor.Putere; } }
        public void Porneste()
        {
            Console.WriteLine("Masina porneste");
            foreach (Usa usa in usi)
            {
                usa.Inchide();
            }
            motor.Porneste();
            Console.WriteLine("Masina a pornit");
        }
        public void Opreste()
        {
            Console.WriteLine("Masina opreste");

            motor.Opreste();

            foreach (Usa usa in usi)
            {
                usa.Deschide();
            }

            Console.WriteLine("Masina s-a oprit");
        }

        public string Description
        {
            get
            {
                return $"{marca}, {model}, {anFabricatie}, {usi.Length}," +
                    $" {motor.CapacitateCilindrica}, {motor.Putere}, {motor.TipCombustibil}";
            }
        }
    }
}

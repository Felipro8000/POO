using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Ej6
{
    internal class Mazo
    {
        private List<Carta> mazo = new List<Carta>();
        public Random rand = new();
        public Mazo() {

            for (int i = 1; i < 13; i++)
            {
                for (int o = 0; o < 4; o++)
                {
                    switch (o)
                    {
                        case 0:
                            mazo.Add(new Carta("Espada", i));
                            break;
                        case 1:
                            mazo.Add(new Carta("Basto", i));
                            break;
                        case 2:
                            mazo.Add(new Carta("Oro", i));
                            break;
                        case 3:
                            mazo.Add(new Carta("Basto", i));
                            break;
                    }
                }
            }
        }
        public void barajar()
        {
            rand.Shuffle<Carta>(CollectionsMarshal.AsSpan(mazo));
        }

        public Carta robarCarta()
        {
            Carta carta = Enumerable.First (mazo);
            mazo.Remove(carta);
            return carta;
        }
        
        public int cuantasCartasQuedan()
        {
            return mazo.Count; 
        }
    }
}

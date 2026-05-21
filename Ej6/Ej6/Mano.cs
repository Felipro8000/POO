using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ej6
{
    internal class Mano
    {
        private List<Carta> mano = new List<Carta>();

        public void recibirCarta(Carta cartaRecibida)
        {
            mano.Add(cartaRecibida);
        }

        public void mostrarMano()
        {
            foreach(Carta c in mano)
            {
                c.mostrarCarta();
            }
        }

        public int cantidadDeCartas()
        {
            return mano.Count;
        }
    }
}

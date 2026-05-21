using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6
{
    internal class Carta
    {
        private string Palo { get; set; }
        private int Numero { get; set; }
        public Carta (string Palo, int Numero) {
            this.Palo = Palo;
            this.Numero = Numero;        
        }

        public void mostrarCarta()
        {
            Console.WriteLine("{0} de {1}", Numero, Palo);
        }


    }
}

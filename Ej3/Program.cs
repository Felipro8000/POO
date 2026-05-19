using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3 {
    internal class Program{
        static void Main(string[] args){
            Ijugador amateur = new Amateur();
            Ijugador profecional = new Profecional();
            Console.WriteLine(amateur.correr(10));
            Console.WriteLine(amateur.correr(20));
            Console.WriteLine(amateur.cansado());
            amateur.descansar(15);
            Console.WriteLine(amateur.cansado());
            Console.WriteLine(amateur.correr(17));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3 {
    class Profecional:Ijugador{
        public int tiempo {get; set;}
        public Profecional()
        {
            tiempo = 40;
        }

        public bool correr(int minutos){
            if (tiempo > minutos)
            {
                tiempo -= minutos;
                return true;
            }
            else {
                return false;
                tiempo = 0;
            }
        }

        public bool cansado(){
            return (tiempo == 0);
        } 

        public void descansar(int minutos){
            if (tiempo + minutos > 40){
                tiempo = 40;
            }
            else {
                tiempo += minutos;
            }
        }
    }
}
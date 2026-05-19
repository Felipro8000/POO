using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3 {
    class Amateur:Ijugador{
        public int tiempo {get; set;}
        public Amateur()
        {
            tiempo = 20;
        }

        public bool correr(int minutos){
            if (tiempo > minutos)
            {
                tiempo -= minutos;
                return true;
            }
            else {
                tiempo = 0;
                return false;
            }
        }

        public bool cansado(){
            return (tiempo == 0);
        } 

        public void descansar(int minutos){
            if (tiempo + minutos > 20){
                tiempo = 20;
            }
            else {
                tiempo += minutos;
            }
        }
    }
}
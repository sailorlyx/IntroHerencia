using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perrito = new Perro();
            perrito.uwu();
            
            Gato gatito = new Gato();
            gatito.uwu();

            Console.WriteLine("mi perrito es de color {0} y de la raza {1}", perrito.color, perrito.raza);
            Console.WriteLine("mi gatito es de color {0} y de la raza {1}", gatito.color, gatito.raza);
            
           
        }
    }
}

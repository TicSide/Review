using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Exercise
{
    internal class Nubes
    {
        public void TypeNube() {
            Console.WriteLine("Estas conectando a la nube");
        }
        public void TypeNube(string n)
        {
            Console.WriteLine("Usted se esta conecntando a: " + n);
        }
        public void TypeNube(int n)
        {
            Console.WriteLine("Su numero de nube que esta conectando con el id: {0}",n);
        }
    }
}

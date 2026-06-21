using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id = "s";


            if (int.TryParse(id, out int valor))
            {
                Console.WriteLine("Entonces el resultado es {0} y se considera numerico", id);
            }
            else
            {
                Console.WriteLine();
            }


        }
    }
}

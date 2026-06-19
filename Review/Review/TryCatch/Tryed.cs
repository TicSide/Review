using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.TryCatch
{
    public class Tryed
    {
        public void Exercise1()
        {
            int number1=0, number2=0;
            int resultado = 0;
            try {
                Console.Write("Ingrese el numero 1: ");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el numero 2: ");
                number2 = Convert.ToInt32(Console.ReadLine());

                resultado = number1 + number2;
                Console.WriteLine(resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un valor numero entero no decimal o textos");
            }

        } 

    }
}

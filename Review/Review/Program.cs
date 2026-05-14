    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define the variables
            double num1, num2, result=0;
            int option;
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Bienvenido a la calculadora de C#");
            Console.WriteLine("Seleccione la operación que desea realizar:");


            do
            {

                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Ingrese la opcion que requiera rehalizar");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Porcentaje");
                Console.WriteLine("6. Potencia");
                Console.WriteLine("0. Salir");
                Console.WriteLine("------------------------------------------------------");
                Console.Write("opcion: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------------------------------------");

                if (option == 1)
                {
                    Console.WriteLine("Ingrese el primer valor: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo valor: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 + num2;
                }
                if(option == 2)
                {
                    Console.WriteLine("Ingrese el primer valor: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo valor: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 - num2;
                }
                if (option == 3)
                {
                    Console.WriteLine("Ingrese el primer valor: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo valor: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 * num2;
                }
                if (option == 4)
                {
                    Console.WriteLine("Ingrese el primer valor: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo valor: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if(num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre cero");
                    }

                }
                if (option == 5)
                {
                    Console.WriteLine("Ingrese el primer valor: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo valor: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = (num1 * num2) / 100;
                }
                if (option == 6)
                {
                    Console.WriteLine("Ingrese el primer valor: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo valor: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = Math.Pow(num1, num2);
                }


                if (option > 0 && option <= 6)
                {
                    Console.WriteLine("------------------------------------------------------");

                    Console.WriteLine("El resultado es: {0}", result);

                }
            }
            while (option >= 0 && option <= 6);
            }
        }
    }


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
            ToDo toDo=new ToDo();
            int option;
            try
            {
                do
                {

                    toDo.menuToDo();
                    Console.ForegroundColor = ConsoleColor.White;
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        default:
                            break;
                    }

                } while (option > 0 && option < 6);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("#####################");
                Console.WriteLine("\tERROR");
                Console.WriteLine("#####################");
                Console.WriteLine("Ingrese un valor numerico entero (example: 1, 3, 4) Ni usar cadenas de texto");
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Finalizar programa to-do en");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 5; i >=0; i--)
                {
                    Console.Write(" "+i);
                    Thread.Sleep(1500);
                    if (i == 1)
                    {
                        Console.Clear();
                        break;
                    }
                   
                }
            }

        }
    }
}

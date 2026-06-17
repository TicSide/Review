using System;
using System.Threading;

namespace Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            Duplicar(ref numero);
            Console.WriteLine(numero);

            string nombrePrueba = "Sauron";
            Console.WriteLine("Su nombre de prueba es: " + nombrePrueba);
            CambiarNombre(ref nombrePrueba);
            Console.WriteLine(nombrePrueba);

            decimal precioIva = 10.0m;
            Console.WriteLine(precioIva + "%");
            AgregarImpuesto(ref precioIva);
            Console.WriteLine(precioIva + "%");

            decimal price = 3800.0m;
            Console.WriteLine("Se le hara un descuento del 10% al producto con: " + price);
            AplicarDescuento(ref price);
            Console.WriteLine("Con descuento seria: " + price);

            string texto = "asdjlaksd";
            Console.WriteLine(texto);
            ConvertirAMayusculas(ref texto);
            Console.WriteLine(texto);

        }
        public static void Duplicar(ref int numero)
        {
            numero *= 2;
        }

        public static string CambiarNombre(ref string nombre)
        {
            Console.WriteLine("Ponga el nombre que desee cambiarlo");
            nombre = Console.ReadLine();
            return nombre;
        }
        public static decimal AgregarImpuesto(ref decimal precio)
        {
            precio = 18.0m;
            return precio;
        }
        public static int ReiniciarContador(ref int contador)
        {
            contador = 0;
            return contador;
        }
        public static decimal AplicarDescuento(ref decimal total)
        {
            decimal discount=10m;
            decimal finalTotal = 0;
            total = total - (total * (discount/100));
            return total;
        }
        public static string ConvertirAMayusculas(ref string texto)
        {
            texto=texto.ToUpper();
            return texto;
        }
    }
}

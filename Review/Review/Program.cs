using Review.Services;
using System;
using System.Threading;
using System.IO;
namespace Review
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int a = 2; int b = 5;
                int sum = a + b;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

            }

            CalculadoraService cal = new CalculadoraService();
            cal.CalculadoraDosNumeros(10, 11);
            cal.CalculadoraTresNumeros(10,53, 21);
            cal.CalculadoraVariosNumeros(1, 2, 3, 4, 5, 6);

            if (cal.TryDividir(12, 2,out int pppp))
            {
                Console.WriteLine(pppp);
            }
            else
            {
                Console.WriteLine("WTF");
            }

            UsuarioService user = new UsuarioService();
            user.Login(32212);
            user.Login("log@gmail.com");

            user.LoginUsers("Pa", "Pe", "Miau","Pa", "Pe", "Miau");

            user.OptionalLogin("ZZZ", out string res);
            Console.WriteLine(res);



            if (TryConvertirEdad("25", out int edad))
            {
                Console.WriteLine($"Edad: {edad}");
            }
            else
            {
                Console.WriteLine("Edad inválida");
            }

            if (TryDividir(10, 2, out int resultado))
            {
                Console.WriteLine($"Resultado: {resultado}");
            }
            else
            {
                Console.WriteLine("No se puede dividir entre cero");
            }

            if (TryObtenerProducto(2, out string result)){
                Console.WriteLine(result);
            }
            {
                Console.WriteLine("zzz");
            }

            if (TryValidarEmail("admin@gmail.com", out string email))
            {
                Console.WriteLine(email);
            }
            else
            {
                Console.WriteLine("Usted no pertenece");
            }



            {
                Console.WriteLine("Ingrese el primer numero: ");
                string valorN1 = Console.ReadLine();

                Console.WriteLine("Ingrese el segundo numero: ");
                string valorN2 = Console.ReadLine();
                int sumatoria;

                if ((int.TryParse(valorN1, out int N1)) && (int.TryParse(valorN2, out int N2)))
                {
                    sumatoria = N1 + N2;
                    Console.WriteLine("La suma es: " + sumatoria);
                }
                else
                {
                    Console.WriteLine("Ingrese un valor numerico en alguno delos numeros");
                }

            }
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
        }
        public static bool TryConvertirEdad(string texto, out int edad)
        {
            return int.TryParse(texto, out edad);
        }

        public static bool TryDividir(int a, int b, out int resultado)
        {
            if (b == 0)
            {
                resultado = 0;
                return false;
            }

            resultado = a / b;
            return true;

        }

        public static bool TryObtenerProducto(int id, out string producto)
        {
            if (id == 1) {
                producto = "laptop";
                return true;
            }
            if (id == 2)
            {
                producto = "celular";
                return true;
            }
            producto = "";
            return false;
        }

        public static bool TryValidarEmail(string email, out string mensaje)
        {
            if(email == "admin@gmail.com")
            {
                mensaje = "Bienvenido adming";
                return true;
            }
            else if (email == "admin@gmail2.com")
            {
                mensaje = "Bienvenido adming";
                return true;
            }
            else
            {
                mensaje = "Usted no es un admin";
                return false;
            }
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

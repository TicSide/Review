using Review.Exercise;
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
            WelcomeMessage welcomeMessage = new WelcomeMessage();

            welcomeMessage.Welcome();
            welcomeMessage.Welcome("John");
            FindProduct findProduct= new FindProduct();
            findProduct.BuscarProducto(12, "Papitas");

            Nubes nubes = new Nubes();
            nubes.TypeNube();
            nubes.TypeNube("goku");
            nubes.TypeNube(1);


            Profile profile = new Profile();
            profile.Perfil("george");
            profile.Perfil("george","georgi@gmail.com");
            profile.Perfil("george", "georgi@gmail.com",22);
    
            Program program= new Program();
            program.internet(1, 2, 3, 4, 5);

            Params pipapu= new Params();
            pipapu.PromediarNotas(1, 3, 5, 2, 1);

            pipapu.UnirPalabras("Paolo","", "futbol11", "zeus","","","asdasd");

        }

        public void internet(params int[] numeros) {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }


        }
    }
}

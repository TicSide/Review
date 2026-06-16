using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Exercise
{
    internal class Profile
    {
        public void Perfil(string name)
        {
            Console.WriteLine("Usted se esta logueando con: {0}", name);
        }
        public void Perfil(string name, string email)
        {
            Console.WriteLine("Usted se esta logueando con: {0} y con el mail: {1}", name, email);
        }
        public void Perfil(string name, string email, int edad)
        {
            Console.WriteLine("Usted se esta logueando con: {0} y con el mail: {1} y su edad es {2}", name, email, edad);
        }
    }
}

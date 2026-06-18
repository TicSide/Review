using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Services
{
    internal class UsuarioService
    {
        public void Login(int ID)
        {
            Console.WriteLine("Ingresando por el ID: "+ ID);
        }
        public void Login(string email)
        {
            Console.WriteLine("Ingresando por el email: "+ email);
        }
        public void LoginUsers(params string[] users)
        {
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i]);
            }

        }

        public bool OptionalLogin(string usuario, out string validation)
        {
            if (usuario == "goku")
            {
                validation = "Verdadero";
                return true;
            }
            else if (usuario == "ZZZ")
            {
                validation = "Verdadero";
                return true;
            }
            else if(usuario == "Matasanos")
            {
                validation = "Verdadero";
                return true;
            }
            else
            {
                validation = "";
                return false;
            }
        }

    }
}

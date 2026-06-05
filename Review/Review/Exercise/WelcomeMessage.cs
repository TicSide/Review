using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Exercise
{
    internal class WelcomeMessage
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to C# programming!");
        }
        public void Welcome(string name)
        {
            Console.WriteLine($"Welcome to C# programming, {name}!");
        }
        public void Welcome(string name, int edad)
        {
            Console.WriteLine($"Welcome to C# programming, {name}!, {edad}!");
        }



    }
}

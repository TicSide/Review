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
        }

    }
}

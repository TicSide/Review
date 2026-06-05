using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Exercise
{
    internal class FindProduct
    {
        public void BuscarProducto(int id, string name) {
            Console.WriteLine("Buscando por el nombre del producto {1}, y su codigo es {0}", id, name);
        }
    }
}

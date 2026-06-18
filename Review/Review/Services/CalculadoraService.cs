using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Services
{
    class CalculadoraService
    {
        public double CalculadoraDosNumeros(double n1, double n2)
        {
            return n1 + n2;
        }
        public double CalculadoraTresNumeros(double n1, double n2,double n3)
        {
            return n1 + n2 + n3;
        }
        public double CalculadoraVariosNumeros(params double[] numeros) {

            double sumatoria = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                sumatoria += numeros[i];
            }
            return sumatoria;
        }
        public bool TryDividir(int a, int b, out int resultado)
        {
            if (b == 0)
            {
                resultado = 0;
                return false;
            }

            resultado = a / b;
            return true;

        }
    }
}

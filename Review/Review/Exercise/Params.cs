using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Exercise
{
    internal class Params
    {
        public void SumarNumeros(params int[] numeros) {
            int resultado = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                resultado += numeros[i];
            }
            Console.WriteLine(resultado);
        }
        public void PromediarNotas(params decimal[] notas)
        {
            decimal resultadoPromedio = 0;
            int p1 = notas.Length;
            for (int i = 0; i < notas.Length; i++)
            {
                resultadoPromedio += notas[i];
            }
            decimal resultadoTotal = resultadoPromedio / notas.Length;
            Console.WriteLine(resultadoTotal);
        }
        public void MostrarNombres(params string[] nombres)
        {
            for(int i = 0;i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }
        }
        public bool HayCamposVacios(params string[] campos)
        {
            for (int i = 0; i < campos.Length; i++)
            {
                if (campos[i] == "")
                {
                    return true;
                }
            }

            return false;
        }
        public void ObtenerNumeroMayor(params int[] numeros)
        {
            int numeroMayor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > numeroMayor)
                {
                    numeroMayor = numeros[i];
                }
            }

            Console.WriteLine("El número mayor es " + numeroMayor);
        }
        public void UnirPalabras(params string[] palabras)
        {
            string total = "";

            
                for (int i = 0; i < palabras.Length; i++)
                {
                    total+= palabras[i];
                }
            Console.WriteLine(total);
        }
    }
}

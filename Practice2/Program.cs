using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ingrese un numero");
            //int numero = Convert.ToInt32((Console.ReadLine()));
            //int iterador = 0;

            //for (int i = numero; i > -1; i--)
            //{
            //    // Console.WriteLine(i);
            //    iterador += i;
            //}

            //Console.WriteLine(iterador);

            int[] miArreglo = new int[] {1,3,4,6,34,345,3456,345 };

            //foreach (int item in miArreglo)
            //{
            //    Console.WriteLine(item);
            //}

            List<int> miLista = new List<int>();
            
            foreach (int item in miArreglo)
            {
                miLista.Add(item);
            }

            int veces = 0;

            veces = miArreglo.Length;

            for (int i = 0; i < veces; i++) // ojo sintaxis for (iniciador, condicion, /=,*= etc)
            {
                Console.WriteLine(miLista[i]);
            }

            Console.ReadKey();
        }
    }
    public class Practica2
    {  
        //public void SumaAnteriores(int suma)
        //{
        //    List<int> miLista = new List<int>();

        //    for(int i = suma; i>-1;i--)
        //    {
        //        miLista = List<int> i;
        //    }
        //}
    }
}

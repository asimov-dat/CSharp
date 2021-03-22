using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Practice
    {
        static void Main(string[] args)
        {
            string Operacion = "";

            Mostrar mostrar = new Mostrar();

            Console.WriteLine("Bienvenido al Programa de Operaciones");
            Console.WriteLine("Puede escoger entre: Impares, Pares, 0 hasta 100, 100 hasta 0, multiplos de 3, multiplos de 2y3 ");
            Operacion = Console.ReadLine();

            if (Operacion == "Impares")
            {
                for (int i = 0; i <= 100; i++)
                {
                    mostrar.Impares(i);
                }
            }
            else if(Operacion == "Pares")
            {
                for (int i = 0; i <= 100; i++)
                {
                    mostrar.Pares(i);
                }
            }
            else if(Operacion == "0 hasta 100")
            {
                for(int i = 0; i <= 100; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if(Operacion == "100 hasta 0")
            {
                for(int i = 100; i > -1; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else if(Operacion == "multiplos de 3")
            {
                for(int i = 0; i <=100; i++)
                {
                    mostrar.Multiplode3(i);
                }
            }
            else if(Operacion == "multiplos de 2y3")
            {
                for(int i = 0; i<=100; i++)
                {
                    mostrar.Multiplode2y3(i);
                }
            }
            else
            {
                Console.WriteLine("Mala sintaxis men, ahora muere!!!!");
            }

            Console.ReadKey();
        }
    }
    public class Mostrar
    {
        public void Impares(int Impar)
        {
            if (Impar %2 !=0)
            {
                Console.WriteLine(Impar);
            }
        }
        public void Pares(int Par)
        {
            if (Par % 2 == 0)
            {
                Console.WriteLine(Par);
            }
        }
        public void Multiplode3(int Multiplo3)
        {
            if(Multiplo3 % 3 == 0)
            {
                Console.WriteLine(Multiplo3);
            }
        }
        public void Multiplode2y3(int Multiplo2y3)
        {
            if(Multiplo2y3 % 2 == 0 && Multiplo2y3 % 3 == 0)
            {
                Console.WriteLine(Multiplo2y3);
            }
        }
    }
}
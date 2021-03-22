using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //for (int i = 0; i < 10; i += 3) notacion in 3rd space: i +=, i -=, i /=, i *=
            //{
            //    //if (i == )
            //    //{
            //    //    continue;
            //    //    Console.WriteLine("Ahora soy cinco");

            //    //}
            //    //Console.WriteLine("Hola mundo {0}", i);

            //    if (i % 2 == 0 && i != 0) { Console.WriteLine(i); }


            //}
            //  ----Ciclo

           // int[] miArrelgo = new int[] {1,2,5,45,45,56,89,2};

            //string me = "David";\

            //int me = 6;

            //int cantidadElementos =  miArrelgo.Length;



            //List<int> miLista = new List<int>();

            //int cantidadLista = miLista.Count();


            //foreach(int i in miArrelgo)
            //{
            //    Console.WriteLine(i +100);----> los puedo editar
            //}

            //foreach (int x in miLista) 
            //{

            //}

            //int comenzar =  0;
            //while (comenzar < 10)-------> ciclo while
            //{
            //    Console.WriteLine("Life is suffering");
            //    comenzar++;
            //}


            //------------------------------


            //Perro miperro = new Perro();
            //miperro.Ladrar(miArrelgo);

            //int valor1 = 16;
            //string valor2 = "Jhon";

            //miperro.DecirMiNombre(valor1);
            //miperro.DecirMiNombre(valor2);
            //miperro.DecirMiNombre(valor2, valor1);


            // Console.WriteLine(miperro.DevolverEntero(10) + 5);

            //Console.ReadKey();


            int[] miArrelgo = new int[] { 1, 2, 5, 45, 45, 56, 89, 2 };

            //forma básica

            foreach(int item in miArrelgo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------");

            //forma más avanzada usando action
            Action<int> action = new Action<int>(Imprimir);
            Array.ForEach(miArrelgo,  action);

            Console.WriteLine("-----------------------------");

            Array.ForEach(miArrelgo, s  => Console.WriteLine(s));


            Console.ReadKey();

        }

        private static void Imprimir(int valor )
        {
            Console.WriteLine(valor);
        }
    }

    public class Perro
    {
        //public string tipoDeRaza = "Doberman"; ---> atributo

        public void Ladrar(int[] mAnose )
        {
            foreach (int n in mAnose) 
            {
                Console.WriteLine(n+200);
            }
            
        }

        public void DecirMiNombre(int miNombre)
        {
            Console.WriteLine($"Me llamo {miNombre}");
        }

        public void DecirMiNombre(string miNombre)
        {
            Console.WriteLine($"Hola {miNombre}");
        }
        public void DecirMiNombre(string miNombre, int entero)
        {
            Console.WriteLine($"Hola {miNombre}{entero}");
        }

        public int DevolverEntero(int numerox)
        {
            return 5 + numerox;
        }

    }

}

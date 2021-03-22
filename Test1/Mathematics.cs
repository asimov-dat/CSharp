using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matematicas numeroPi = new Matematicas();
            //numeroPi.Retorno();
            //numeroPi.RetornarString();


            //Console.WriteLine(numeroPi.PI);

            //Console.WriteLine(numeroPi.Retorno());

            //numeroPi.PI;
            //double otroPI = numeroPi.Retorno() + 4545645;
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());

            Matematicas sumaDosNumeros = new Matematicas(x1, x2);

            //int[] arreglo = new int[] {1,5,6,8,0,2,4};

            //int temporal = arreglo[0];
            //arreglo[0] = arreglo[1];
            //arreglo[1] = temporal;
        }
    }

    public class Matematicas
    {
        private Geometria geomtria1 = new Geometria();
        private int a;
        private int b;


        public void CalcularTriando(Geometria geomtria)
        {
            int suma = geomtria1.numeroLados + 5;    
        }

        public Matematicas(int a, int b)
        {
            this.a = a;
            this.b = b;
            
            Console.WriteLine(Suma());
            Console.ReadKey();
        }
        private int Suma() 
        {
            return a + b;
        }

        //public double PI = 3.142347263445723;

        //public double Retorno()
        //{
        //    return PI+3;
        //}

        //public string RetornarString()
        //{
        //    return "Hola";
        //}

        //private string nombre;

        //public Matematicas(string iniciarNombre)
        //{
        //    this.nombre = iniciarNombre;
        //    Imprimir();
        //}

        //private void Imprimir()
        //{
        //    Console.WriteLine($"Hola {this.nombre} soy el constructor");
        //    Console.ReadKey();
        //}

        //public string Prueba(string comoQuiera)
        //{
        //    return comoQuiera;
        //}
    }

    public class Geometria
    {
        public int numeroLados;

        public Geometria()
        {
            this.numeroLados = 5;
        }
    }
}

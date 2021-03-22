using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro();
            perro.Salario = -50;

            perro.ImprimirSalario();
            Console.ReadKey();
        }
    }
    public class Perro
    {
       // public string Nombre { get; set; }

        private int edad;
        private int salario = 100;
        private string nombre;

        public int Edad { get => edad; set => edad = value; }
        public int Salario { get => salario; set => salario = value; }
        public string Nombre { get => nombre; set => nombre = value; }


        const;

        readonly;

        //  public string Nombre { get => nombre; private set => nombre = value; } ----> solo atributos

        /* public int Salario
         {
             get
             {
                 if (salario > 0)
                 {
                     return salario;
                 }
                 else 
                 {
                     return 0;
                 }
             }
             set
             {
                 if (salario > 9000000)
                 {
                     salario = value;
                 }
                 else
                 {
                     salario = 0;
                 }
             }
         }
        */

        public void ImprimirNombre()
        {
            Console.WriteLine($"Mi nombre es {this.nombre}");
        }
        public void ImprimirSalario()
        {
            Console.WriteLine($"Mi salario es {this.salario} pesos");
        }
    }
}

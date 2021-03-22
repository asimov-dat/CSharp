using System;


namespace clases // no es un archivo que se pueda ejecutar, no tiene un metodo main desde donde emnpezar a correr el programa
{
    public class Mathematics
    {
        int n1 = Console.ReadLine(); // consola ecibe string
        int n2 = 0;

        Mathematics Suma = new Mathematics(int n1); //ya estoy aqui para quer invocar esto
        this.Suma(n1); // no tiene sentido para que llamr algo que esta en la misma clase

        Console.WriteLine(n2);

	public int Suma(int number)
        {
            number + 2;

            public string suma(string describe) // no se que hace si quisiera que la convirtiera la string crEARIA OTRA CLASE Y LUEGO SE INVOCA AQUI
            {
                describe = Suma;
                Console.WriteLine(describe);
            }
        }
    }

    public void LeerLinea()
    {
        Console.WriteLine("Escriba un número");
        int valor = Convert.ToInt32((Console.ReadLine()));
    }


    public class Perro
    {
        int edad = 10;
        string tipoDePelo = "Castaño";

       

        private void Saludar()
        {
            int variableCerrada = 10;
            valor = 10;
            Console.WriteLine(valor);
            
        }
        private void Despedir()
        {
            variableCerrada = 10;
            valor = 5;
            Console.WriteLine(valor);
            
        }



    }
}



    



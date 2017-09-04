using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// Método principal
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Title = "Console Title";
            //Console.WriteLine("Hello World!");

            /*
            Console.Write("Nombre: ");
            string name = Console.ReadLine();
            Console.Write("Apellidos: ");
            string subname = Console.ReadLine();
            Console.Write("Edad: ");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.Write("Fecha de nacimiento: ");
            DateTime bornAge = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\n\n*****************************************************");
            Console.WriteLine("*******            Datos personales           *******");
            Console.WriteLine("*****************************************************\n");
            Console.WriteLine("Nombre completo: " + name + subname);
            Console.WriteLine("fecha de nacimiento: " + Convert.ToDateTime(bornAge) + "\t Edad: " + age);
            Console.ReadKey();
            */

            Console.WriteLine("\n\n*****************************************************");
            Console.WriteLine("*******    Variables Implicitas/Explicitas    *******");
            Console.WriteLine("*****************************************************\n");
            var x = 1; //variable implicita
            int y = 10; //variable explicita
            var suma = x + y;
            Console.WriteLine("La suma de x + y es: {0} + {1} = {2}", x, y, suma);
            Console.WriteLine("El producto de x * y es: {0} * {1} = {2}", x, y, x * y);
            Console.ReadKey();
        }
    }
}

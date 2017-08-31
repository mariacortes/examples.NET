using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Console Title";
            //Console.WriteLine("Hello World!");

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
        }
    }
}

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

            /*
            Console.WriteLine("\n\n*****************************************************");
            Console.WriteLine("*******    Variables Implicitas/Explicitas    *******");
            Console.WriteLine("*****************************************************\n");
            var x = 1; //variable implicita
            int y = 10; //variable explicita
            var suma = x + y;
            Console.WriteLine("La suma de x + y es: {0} + {1} = {2}", x, y, suma);
            Console.WriteLine("El producto de x * y es: {0} * {1} = {2}", x, y, x * y);
            //Console.ReadKey();

            Console.WriteLine("\n\n*****************************************************");
            Console.WriteLine("*******          Variables Flotantes          *******");
            Console.WriteLine("*****************************************************\n");
            float a = 0.5f; //f final para especificar el tipo float.

            double b = 5d; //d final para especificar el tipo int(double);
            double c = 0.5; //no se pone nada y es de tipo float(double);
            Console.WriteLine("La suma de b + c es: {0} + {1} = {2}", b, c, b + c);
            Console.ReadKey();
            */

            Console.WriteLine("\n\n*****************************************************");
            Console.WriteLine("*******          Variables Booleanas          *******");
            Console.WriteLine("*****************************************************\n");

            char answer = 'n';
            bool stop = false;
            int num = 0;
            bool isExcept = false;
            bool isTrue = true;
            bool isChar = false;
            bool isInt = false;

            while (!stop)
            {
                if (!isExcept)
                {
                    Console.Write("Introduzca un número para probar suerte: ");
                    isInt = Int32.TryParse(Console.ReadLine(), out num);
                    isTrue = (num == 11);
                }

                if (!isTrue || isExcept)
                {
                    if (isExcept)
                    {
                        Console.Write("{0} no es una opción, introduzca s/n: ", answer);
                        isChar = char.TryParse(Console.ReadLine(), out answer);
                        isExcept = false;
                    } 
                    else if (!isExcept)
                    {
                        Console.Write("Lo siento, no ha acertado, ¿desea probar otra vez? (s/n): ");
                        isChar = char.TryParse(Console.ReadLine(), out answer);
                    }
                    else { }

                    if (answer == 'n')
                    {
                        stop = true;
                        Console.ReadKey();
                    }
                    else if (answer == 's')
                    {
                        stop = false;
                    }
                    else
                    {
                        isExcept = true;
                        stop = false;
                    }
                }
                else if (isTrue)
                {
                    Console.WriteLine("!Enhorabuena, has ganado!");
                    stop = true;
                    Console.ReadKey();
                }
                else { }
            }
        }
    }
}

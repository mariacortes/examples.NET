using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class VectorElements
    {
        private int[] vector;

        public void InsertVector()
        {
            vector = new int[8];

            for(int i = 0; i < 8; i++)
            {
                Console.Write("Introduzca un elemento: ");
                vector[i] = Int32.Parse(Console.ReadLine());
                Console.Write("\n");
            }
        }

        public void AcumulatedVector()
        {
            int sum = 0;
            for(int i = 0; i < 8; i++)
            {
                sum += vector[i];
            }
            Console.WriteLine("La suma de todos los elementos del vector es: " + sum);
        }

        public void GreatherThan36Vector()
        {
            int sum = 0;
            for (int i = 0;i< 8; i++)
            {
                if(vector[i] > 36)
                {
                    sum += vector[i];
                }
            }
            Console.WriteLine("La suma de los elementos >36 es: " + sum);
        }

        public void QuantityGratherThan50Vector()
        {
            int cont = 0;
            for(int i = 0; i < 8; i++)
            {
                if(vector[i] > 50)
                {
                    ++cont;
                }
            }
            Console.WriteLine("Existen {0} elementos >50.", cont);
        }
    }
}

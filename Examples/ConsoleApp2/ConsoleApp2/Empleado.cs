using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Empleado
    {
        private string nombreEmpleado;
        private double sueldo;

        public void InsertarDatos()
        {
            Console.Write("Introduzca el nombre del empleado: ");
            nombreEmpleado = Console.ReadLine();
            Console.Write("Introduzca el sueldo: ");
            sueldo = double.Parse(Console.ReadLine());
        }

        public void ImprimirEmpleado()
        {
            Console.WriteLine("Nombre empleado: " + nombreEmpleado);
            Console.WriteLine("Sueldo: " + sueldo);
        }

        public void PagarImpuesto()
        {
            if(sueldo > 3000)
            {
                Console.WriteLine("El empleado {0} tiene que pagar impuestos.", nombreEmpleado);
            }
            else
            {
                Console.WriteLine("El empleado {0} no tiene que pagar impuestos.", nombreEmpleado);
            }
        }
    }
}

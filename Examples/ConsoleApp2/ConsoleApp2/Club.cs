using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Club
    {

        private List<Partner> partners;

        public Club()
        {
            partners = new List<Partner>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Introduzca el nombre del socio: ");
                string nameP = Console.ReadLine();
                Console.Write("Introduzca la antigüedad del socio: ");
                int partnerYearP = Int32.Parse(Console.ReadLine());

                partners.Add(new Partner() { Name = nameP, PartnerYears = partnerYearP });
            }
        }

        public void PrintGreaterYearsPartner()
        {
            partners.Sort();
            Partner last = partners.Last();

            Console.Write("El socio más antiguo es {0}", last.Name);
        }
    }
}

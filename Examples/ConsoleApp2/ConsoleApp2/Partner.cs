using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Partner: IComparable<Partner>
    {
        private string name;
        private int partnerYears;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int PartnerYears
        {
            get
            {
                return partnerYears;
            }
            set
            {   
                if(partnerYears >= 0)
                {
                    partnerYears = value;
                }
                else
                {
                    Console.WriteLine("La antigüedad de un socio no puede ser negativa");
                }
            }
        }

        public int CompareTo(Partner otherPartner)
        {
            if (this.PartnerYears == otherPartner.PartnerYears)
            {
                return this.Name.CompareTo(otherPartner.Name);
            }

            return this.PartnerYears.CompareTo(otherPartner.PartnerYears);
        }
    }
}

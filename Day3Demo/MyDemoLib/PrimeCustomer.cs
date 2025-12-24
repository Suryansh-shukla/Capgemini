using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoLib
{
   public class PrimeCustomer:Customer
    {
        public string CustName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
    }
}

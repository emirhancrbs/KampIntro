using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Miras - inheritance => CoorporateCustomer:Customer
    internal class CoorporateCustomer:Customer
    {
        public string TaxNumber { get; set; }
        public string CompanyName { get; set; }
    }
}

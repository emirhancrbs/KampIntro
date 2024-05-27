using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Miras - inheritance => IndividualCustomer:Customer
    internal class IndividualCustomer:Customer
    {
        public string TcNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

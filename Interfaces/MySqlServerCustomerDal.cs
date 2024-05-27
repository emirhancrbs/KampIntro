using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class MySqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");

        }

        public void Delete()
        {
            Console.WriteLine("MySql Deelte");

        }

        public void Update()
        {
            Console.WriteLine("MySql Update");
        }
    }
}

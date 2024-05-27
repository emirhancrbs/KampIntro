using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrate
{
    public class CustomerCheckManager : ICustomerCheckService
    {
       public Task<bool> CheckIfRealPerson(Customer customer)
        {
            return Task.FromResult(true);
        }

    }
}

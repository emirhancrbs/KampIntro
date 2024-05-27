using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entites;

namespace InterfaceAbstractDemo.Concrate
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer).Result)
            {
                base.Save(customer);
            }
            else
            {

                throw new Exception("Nat a valid person");

            }

        }


    }
}

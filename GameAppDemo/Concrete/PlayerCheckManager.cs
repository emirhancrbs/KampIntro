using GameAppDemo.Abstract;
using GameAppDemo.Entities;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entites;

namespace GameAppDemo.Concrete
{
    public class PlayerCheckManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;
        public PlayerCheckManager(ICustomerCheckService customerCheckService)
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

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new  SqlServerCustomerDal());
            ICustomerDal[] customerDals = new ICustomerDal[] {new SqlServerCustomerDal(),new OracleServerCustomerDal(),new MySqlServerCustomerDal() };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }
    }
}

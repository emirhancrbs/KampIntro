namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Emirhan";
            customer1.LastName = "Çeribaş";
            customer1.TcNumber = "12345678910";
            

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber="54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "15296486";


            //Customer hem IndividualCustomer ın referansını tıtabiliyor hemde CoorporateCustomer referansını tutabiliyor.
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();


            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}

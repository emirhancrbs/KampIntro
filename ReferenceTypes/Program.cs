using System.Globalization;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "emir";
            person2 = person1;
            person1.FirstName = "Derin";
         

            Console.WriteLine(person1.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "salih";
            customer.CreditCardNumber = "12345678910";
            Employee employee = new Employee();
            employee.FirstName = "Yağmur";
            Person person3 = customer;
            customer.FirstName = "Ahmet";
                                //Customer Boxing 
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            PersonManager personManager = new PersonManager();
            //Add(Person person)=>add fonksiyonu person türünden bir değer istiyor fakat biz customer türünde veri gönderebiliyoruz.Base classı parametre olarak istediğimiz için customer employee gönderebiliyoruz.
            personManager.Add(employee);
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    //inheritance - Kalıtım => Customer Bir Persondur diyoruz.
    class Customer :Person 
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmplooyeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

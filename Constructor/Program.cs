using System.Globalization;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Emirhan", LastName = "Çeribaş", City = "İstanbul" };
            Customer customer2 = new Customer(2,"Yağmur","Türkköylü","Bursa");
        }
    }
    class Customer
    {
        //default constructor
        public Customer(int id,string firstName,string lastName,string city)
        {
            Console.WriteLine("Yapıcı blok çalıştı");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

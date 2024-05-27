using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrate;
using InterfaceAbstractDemo.Entites;
using MernisServiceReference;
using System.Net.WebSockets;

namespace InterfaceAbstractDemo
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {DateOfBirth = new DateTime(2002,6,9),FirstName="Emirhan",LastName ="Çeribaş",NationalityId ="16514310146",Id=1 });
            
           
        }
    }
}

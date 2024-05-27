using System;
using InterfaceAbstractDemo.Abstract;

namespace InterfaceAbstractDemo.Entites
{
    //Somur sınıflar çıplak kalıyorsa yani herhangi bir intheritance veya implementation almıyorsa ileride nesnellik zaafiyeti sorunu yaşarız.
    public class Customer :IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace SkaityklaProject
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public int BuildingNumber { get; set; }
        public int FlatNumber { get; set; }
        public int ZipIndex { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public void AddAddress()//????
        {

            Console.WriteLine("Please enter Street name:");
            Street = Console.ReadLine();
            Console.WriteLine("Please enter City name:");
            City = Console.ReadLine();
            Console.WriteLine("Please enter Country name:");
            Country = Console.ReadLine();
            Console.WriteLine("Please enter State name:");
            State = Console.ReadLine();
            Console.WriteLine("Please enter Buiding number:");
            BuildingNumber = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Flat number:");
            FlatNumber = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Zip code:");
            ZipIndex = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Phone number:");
            Phone = Console.ReadLine();
            Console.WriteLine("Please enter Email address:");
            Email = Console.ReadLine();

        }  
        public static Address FillAddress()//????
        {
            Address address = new Address();
            Console.WriteLine("Please enter Street name:");
            address.Street = Console.ReadLine();
            Console.WriteLine("Please enter City name:");
            address.City = Console.ReadLine();
            Console.WriteLine("Please enter Country name:");
            address.Country = Console.ReadLine();
            Console.WriteLine("Please enter State name:");
            address.State = Console.ReadLine();
            Console.WriteLine("Please enter Buiding number:");
            address.BuildingNumber = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Flat number:");
            address.FlatNumber = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Zip code:");
            address.ZipIndex = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Phone number:");
            address.Phone = Console.ReadLine();
            Console.WriteLine("Please enter Email address:");
            address.Email = Console.ReadLine();

            return address;

        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;


namespace SkaityklaProject
{
    public class PublishHouse
    {
        public  Address Address { get; set; }
        public  string PublishHouseName { get; set; }

        public static PublishHouse FillHouse()
        {
            PublishHouse house = new PublishHouse();
            Console.WriteLine("Please enter publish house name:");
            house.PublishHouseName = Console.ReadLine();
            house.Address = Address.FillAddress();
            return house;
        }
    }

   
}
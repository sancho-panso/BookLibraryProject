using System;
using System.Collections.Generic;
using System.Text;

namespace SkaityklaProject
{
   
    class UserName
    {
        //public UserName(string name, string surname)
        //{
        //    this.Name = name;
        //    this.Surname = surname;
        //}
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname { get => Name + " " + Surname;}

        public void AddName()
        {
            Console.WriteLine("Please enter name:");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter suname:");
            Surname = Console.ReadLine();
        }  
        public static UserName FillName()
        {
            UserName name = new UserName();
            Console.WriteLine("Please enter name:");
            name.Name = Console.ReadLine();
            Console.WriteLine("Please enter suname:");
            name.Surname = Console.ReadLine();
            return name;
        }

    }
}

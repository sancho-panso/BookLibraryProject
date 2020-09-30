
using System;
using System.Collections.Generic;
using System.Text;

namespace SkaityklaProject
{
    class Library
    {
        public Library(Address address, string branch)
        {
            this.Address = address;
            this.BranchName = branch;
            List<User> Users = new List<User>();
            List<Book> Books = new List<Book>();
            List<Lending> Lendings = new List<Lending>();

        }
        public Address Address { get; set; }
        public  string BranchName { get; set; }
        public  List<User> Users { get; set; }
        public  List<Book> Books { get; set; }
        public  List<Lending> Lendings { get; set; }

        public void AddNewBook ()// book dublicate search??
        {           
            Books.Add(Book.AddBook());
        }

        public void RemoveOldBook(Book book)
        {
            Books.Remove(book);
        }

        public void LendBook(User user, Book book, DateTime dueDate)
        {
            Lending lend = new Lending(user, book);
            lend.SetNewDueTime(dueDate);
            lend.Status = Status.lended;
            Lendings.Add(lend);
           
        }

        public  void ReceivedBackBook()//linQ through list??
        {

        }

        public  void AddNewUser()
        {
            User user = new User();// author=user case??
            user.UserName = UserName.FillName();
            user.Address = Address.FillAddress();
            Users.Add(user);
        }

    }
}


using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkaityklaProject
{
    class Book
    {
        public Book()
        {
            Guid g = Guid.NewGuid();
            BookID = g;
            List<Review> Reviews = new List<Review>();
            Genre = Genre.undifiend;

        }
        public Guid BookID { get; set; }
        public UserName Author { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public List<Review> Reviews { get; set; }
        public double Value { get; private set; }
        public int Edition { get; set; }
        public PublishHouse PublishingHouse { get; set; }


        public void SetBookGenre(Genre genre)
        {
            this.Genre = genre;
        }
        public void AddReview(Review review)
        {
            Reviews.Add(review);
        }

        public void SetValue(double value)
        {
            this.Value = value;
        }


        public static Book AddBook()
        {
            Book book = new Book();
            book.Author = UserName.FillName();
            Console.WriteLine("Please enter book's title:");
            book.Title = Console.ReadLine(); 
            Console.WriteLine("Please enter book's value:");
            book.Value = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Please enter book's edition:");
            book.Edition = Int16.Parse(Console.ReadLine());
            book.PublishingHouse = PublishHouse.FillHouse();
            return book;


        }
    }
}

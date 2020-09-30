
using System;
using System.Collections.Generic;
using System.Text;

namespace SkaityklaProject
{
    class Lending
    {
        public Lending(User user, Book book)
        {
            Guid g = Guid.NewGuid();
            LendID = g;
            List<DateTime> OnDueTimes = new List<DateTime>();
            this.User = user;
            this.Book = book;
            this.WasLended = DateTime.Now;
        }
        public  Guid LendID { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
        public Status Status { get; set; }
        public  DateTime WasLended { get; set; }
        public  List<DateTime> OnDueTimes { get; set; }
        public  string Notes { get; set; }

        public void AddNote(string note)
        {
            this.Notes = note;
        }

        public void SetNewDueTime(DateTime date)
        {
            OnDueTimes.Add(date);
        }

    }
}

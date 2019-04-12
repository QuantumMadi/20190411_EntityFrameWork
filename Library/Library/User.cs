using System;
using System.Collections.Generic;

namespace Library
{
    public class User : Entity
    {        
        public string FullName {get;set;}
        public ICollection<Book> BorrowedBooks { get; set; }
        public DateTime BorrowDate { get; set; }
        public User()
        {
            BorrowDate = DateTime.Now.Date;
        }
        public User(string fullname, List<Book> books, DateTime borrowDate)
        {
            FullName = fullname;
            BorrowedBooks = books;
            BorrowDate = borrowDate;
        }
    }
}

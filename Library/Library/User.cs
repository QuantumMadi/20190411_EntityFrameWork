using System.Collections.Generic;

namespace Library
{
    public class User : Entity
    {        
        public string FullName {get;set;}
        public ICollection<Book> BorrowedBooks { get; set; }
        public bool IsBorrow { get; set; }
    }
}

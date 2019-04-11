using System.Collections.Generic;

namespace Library
{
    public class Author
    {
        public string FullName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
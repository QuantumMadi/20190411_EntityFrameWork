using System.Collections.Generic;

namespace EF_Loading
{
    public class Author : Entity
    {
        public string FullName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
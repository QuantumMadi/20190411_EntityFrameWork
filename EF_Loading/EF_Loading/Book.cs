using System;
using System.Collections.Generic;

namespace EF_Loading
{
    public class Book : Entity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
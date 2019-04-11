﻿using System;
using System.Collections.Generic;

namespace ObjectRelationMaping
{
    public class Author : Entity
    {   
        public string FullName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
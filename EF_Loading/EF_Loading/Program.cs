using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Loading
{
    class Program
    {
        static void Main(string[] args)
        {
            //var author = new Author
            //{
            //    FullName = "Pushkin",
            //};
            //var book = new Book
            //{
            //    Name = "FairyTales",
            //    Price = 1000,
            //    AuthorId = author.Id,
            //};
            //using (var context = new Library())
            //{
            //    context.Authors.Add(author);
            //    context.Books.Add(book);
            //    context.SaveChanges();
            //}

            using (var context = new Library())
            {
                var books = context.Books.SingleOrDefault();
                context.Entry(books).Reference("Author").Load();
                var author = books.Author;
            }
        }
    }
}

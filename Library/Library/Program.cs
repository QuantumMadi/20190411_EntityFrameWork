using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            #region authors
            var author = new Author
            {
                FullName = "A.Pushkin",
            };
            var author2 = new Author
            {
                FullName = "F.Dostoevsky",
            };
            var author3 = new Author
            {
                FullName = "A.Mironov",
            };
            var author4 = new Author
            {
                FullName = "A.Duma",
            };
            var author5 = new Author
            {
                FullName = "J.London",
            };
            var author6 = new Author
            {
                FullName = "L.Tolstoy",
            };
            #endregion

            #region books
            var book = new Book();
            book.Name = "Graf Monte Crysto";
            book.Authors.Add(author4);

            var book1 = new Book
            {
                Name = "World and war",
                Authors = { author6 },
            };
            var book2 = new Book
            {
                Name = "Stone guest",
                Authors = {author},
            };
            author4.Books.Add(book);
            author6.Books.Add(book1);
            author.Books.Add(book2);
            #endregion

            #region users
            
            
            #endregion
                   
            using (var context = new AppContext())
            {
                context.Books.AddRange(new List<Book>() { book, book1, book2 });
                context.Authors.AddRange(new List<Author>() { author, author2, author3, author4, author5, author6 });
                context.Users.AddRange(new List<User>() {
                    new User("Madi", 
                    new List<Book>() { book }, DateTime.Today),
                    new User("Aslan", new List<Book>() { book, book1 }, 
                    new DateTime(2018, 12, 30)) });
            }

            //var context = new AppContext();
        }
    }
}

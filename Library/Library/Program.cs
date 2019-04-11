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
            #endregion

            #region books
            var book = new Book
            {
                Name = "Graf Monte Cristo",
                Authors = {author4},               
            };
            #endregion

            //List<Book> books = new List<Book>
            //{
            //    new Book = 
            //};

            va

            var context = new AppContext();
        }
    }
}

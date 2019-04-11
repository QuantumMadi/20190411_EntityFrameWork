using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjectRelationMaping
{
    class Program
    {
        static void Main(string[] args)
        {
            #region data
            var author = new Author
            {
                FullName = "Pushkin",
            };
            var book = new Book
            {
                Name = "FairyTales",
                Price = 1000,
                Author = author,
            };
            #endregion

            using (var context = new AppContext())
            {
                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
            }
        }
    }
}

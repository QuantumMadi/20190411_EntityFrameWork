namespace EF_Loading
{
    using System.Data.Entity;

    public class Library : DbContext
    {
        public Library()
            : base("name=Library")
        {
        }

         public virtual DbSet<Book> Books { get; set; }
         public virtual DbSet<Author> Authors { get; set; }
    }
}
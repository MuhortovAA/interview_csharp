using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public interface IRepository
    {
        void Save(Book b);
        IEnumerable<Book> List();
        Book Get(int id);
    }
    public class BookContext : DbContext
    {
        public BookContext() : base("DefaultConnection") { }

        public DbSet<Book> Books { get; set; }
    }
    public class BookRepository : IDisposable, IRepository
    {
        private BookContext db = new BookContext();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> List()
        {

            yield return new Book() { Id = 1, Name = "Test1" };
            yield return new Book() { Id = 2, Name = "Test2" };
            yield return new Book() { Id = 3, Name = "Test3" };
            yield return new Book() { Id = 4, Name = "Test4" };

            //IEnumerable<Book> list2 = new IEnumerable<Book>() { new Book() { Id = 1, Name = "Test" }; };

            //return list2;
        }

        public void Save(Book b)
        {
            throw new NotImplementedException();
        }
        // методы

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LibraryManager
{
    partial class Processor
    {
        public void AddAuthor()
        {
            Console.WriteLine("First Name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name?");
            string lastName = Console.ReadLine();

            Author author = new Author { FirstName = firstName, LastName = lastName };

            using (var context = new LibraryContext())
            {
                try
                {
                    context.Add(author);
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    Console.WriteLine("Insert error.");
                }
                Console.WriteLine("Insert ok.");
            }
        }

        public void ShowByCategory()
        {
            Console.WriteLine("Category?");
            string category = Console.ReadLine();


            using (var context = new LibraryContext())
            {
                List<Book> books = context.Books.Where(b => b.Category == category).ToList<Book>();
                foreach (Book item in books)
                {
                    Console.WriteLine(item.Title);
                }
            }
        }

        public void NumberOfAuthorBooks()
        {
            Console.WriteLine("AuthorID?");
            int authorID = Convert.ToInt32(Console.ReadLine());

            using (var context = new LibraryContext())
            {
               Console.WriteLine(context.Books.Where(a => a.AuthorId == authorID).Count());
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManager
{
    partial class Processor
    {
        public bool AddAuthor(string firstName, string lastName)
        {
            var author = new Author (firstName, lastName);

            using (var context = new LibraryContext())
            {
                context.Add(author);

                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    return false;
                }
                return true;
            }
        }

        public void ShowByCategory()
        {

        }

        public void NumberOfAuthorBooks()
        {

        }
    }
}

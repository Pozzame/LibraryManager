using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EFLibraryManager
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public ICollection<Book> Books {get; set;} = new List<Book>();
    }
}
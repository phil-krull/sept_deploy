using System.Collections.Generic;

namespace BooksAndAuthors.Models
{
    public class IndexView
    {
        public Author Author {get; set;}
        public List<Author> Authors {get; set;}
        public Book Book {get; set;}
        public List<Book> Books {get; set;}
    }
}
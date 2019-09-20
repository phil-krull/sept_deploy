    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using System;

    namespace BooksAndAuthors.Models
    {
        public class Author
        {
            [Key]
            public int AuthorId { get; set; }

            [Display(Name="Author:")]
            [Required(ErrorMessage="Author must have a name")]
            public string Name { get; set; }
            public DateTime CreatedAt {get;set;}
            public DateTime UpdatedAt {get;set;}

            // navigation property
            List<Book> BooksWritten {get; set;}

            public Author()
            {
                BooksWritten = new List<Book>();
                CreatedAt = DateTime.Now;
                UpdatedAt = DateTime.Now;
            }
        }
    }

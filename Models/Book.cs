    using System.ComponentModel.DataAnnotations;
    using System;

    namespace BooksAndAuthors.Models
    {
        public class Book
        {
            [Key]
            public int BookId { get; set; }

            [Display(Name="Book:")]
            [Required(ErrorMessage="Book must have a title")]
            public string Title { get; set; }

            // reference to an Author
            public int AuthorId {get; set;}
            // navigation properity
            public Author Author {get; set;}
            public DateTime CreatedAt {get;set;}
            public DateTime UpdatedAt {get;set;}

            public Book()
            {
                CreatedAt = DateTime.Now;
                UpdatedAt = DateTime.Now;
            }
        }
    }

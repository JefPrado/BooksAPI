using System;
namespace BooksAPI.Entities
{
    public class Book
    {
        public Book()
        {

            CreatedAt = DateTime.Now;


        }

        public void Update(int id,string author, string description, string title)
        {
            Id = id;
            Author = author;
            Description = description;
            Title = title;
        }

        public int Id { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}


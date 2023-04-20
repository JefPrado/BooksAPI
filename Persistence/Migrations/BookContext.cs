using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using BooksAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksAPI.Persistence.Migrations
{
    public class BookContext : DbContext
    {

        public BookContext(DbContextOptions<BookContext> options) : base(options)
        { }
           
            public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // NÃO ESQUECER DE DEFINIR CHAVE PRIMÁRIA
            builder.Entity<Book>(o =>
            {
                // o.Property(j => j.Title).HasMaxLength(25);
                o.HasKey(j => j.Id);
            });



        }
    }

}
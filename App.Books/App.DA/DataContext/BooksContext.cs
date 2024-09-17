using System;
using System.Collections.Generic;
using App.DA.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.DA.DataContext;

public partial class BooksContext : DbContext
{
  

    public BooksContext(DbContextOptions<BooksContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.bookId).HasName("PK__books__B40CC6CDD34A6E46");

            entity.Property(e => e.bookId).ValueGeneratedNever();
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.title).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

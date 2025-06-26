using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Data
{
    public class FirstAPIContext : DbContext
    {
        public FirstAPIContext(DbContextOptions<FirstAPIContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Ordem Paranormal: Iniciação",
                    Author = "Fabio Yabu",
                    YearPublished = 2022
                },
                new Book
                {
                    Id = 2,
                    Title = "Ordem Paranormal: O Segredo na Floresta - Parte 1",
                    Author = "Fabio Yabu",
                    YearPublished = 2023,
                },
                new Book
                {
                    Id = 3,
                    Title = "Ordem Paranormal: O Segredo na Floresta - Parte 2",
                    Author = "Fabio Yabu",
                    YearPublished = 2024,
                }
            );
        }

        public DbSet<Book> Books { get; set; }
    }
}

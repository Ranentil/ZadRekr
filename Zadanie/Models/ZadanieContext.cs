using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Zadanie.Models
{
    public class ZadanieContext : DbContext
    {
        public DbSet<Entrepreneur> Entrepreneurs { get; set; }


        public string DbPath { get; }

        public ZadanieContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "sqldatabase.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }


    public class Entrepreneur
    {
        public string Id { get; set; }
        public required string Name { get; set; }
        public required string Street { get; set; }
        [MaxLength(10)]
        public required string Code { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }
        [MaxLength(10)]
        public string NIP { get; set; }
    }
}

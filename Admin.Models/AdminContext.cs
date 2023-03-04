
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Sirjan.Models;

namespace Admin.Models
{
    public class AdminContext : DbContext
    {
public AdminContext(DbContextOptions<AdminContext> options) : base(options)
        {

        }

        public AdminContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=1.1.1.1;Database=AdminDb;TrustServerCertificate=True;Integrated Security=false;Initial Catalog=AdminDB;User ID=UserDB;Password=myPassword#;");
        }
    }
}
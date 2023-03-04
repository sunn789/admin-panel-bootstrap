using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace Admin.Models
{
    public class ContextFactory : IDesignTimeDbContextFactory<AdminContext>
    {
        public AdminContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AdminContext>();
            builder.UseSqlServer(@"Server=1.1.1.1;Database=AdminDb;TrustServerCertificate=True;Integrated Security=false;Initial Catalog=AdminDB;User ID=UserDB;Password=myPassword#;");
            return new AdminContext(builder.Options);
        }
    }
}
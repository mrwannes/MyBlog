using Microsoft.EntityFrameworkCore;

namespace MyBlog.Web.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<MyBlog.Web.Models.TestModel> Models { get; set; }
    }
}

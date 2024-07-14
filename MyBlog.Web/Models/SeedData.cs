using Microsoft.EntityFrameworkCore;
using MyBlog.Web.Data;

namespace MyBlog.Web.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TestDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TestDbContext>>()))
            {
                if (context.Models.Any())
                {
                    return;   // DB has been seeded
                }
                context.Models.AddRange(
                    new TestModel
                    {
                        Name = "Anders"
                    },
                    new TestModel
                    {
                        Name = "Cæcilie"
                    },
                    new TestModel
                    {
                        Name = "Emilie"
                    },
                    new TestModel
                    {
                        Name = "Ellie"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

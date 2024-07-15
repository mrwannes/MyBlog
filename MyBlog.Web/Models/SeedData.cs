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
                        Name = "Anders",
                        Age = 34
                    },
                    new TestModel
                    {
                        Name = "Cæcilie",
                        Age = 33
                    },
                    new TestModel
                    {
                        Name = "Emilie",
                        Age = 2
                    },
                    new TestModel
                    {
                        Name = "Ellie",
                        Age = 0
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

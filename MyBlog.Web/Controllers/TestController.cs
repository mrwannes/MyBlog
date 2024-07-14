using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Web.Data;
using MyBlog.Web.Models;

namespace MyBlog.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly TestDbContext _context;
        public TestController(TestDbContext testDbContext)
        {
            _context = testDbContext;
        }
        [HttpGet]
        public IEnumerable<TestModel> GetAll()
        {
            List<TestModel> list = new List<TestModel>();
            list = _context.Models.ToList();
            return list;
        }
    }
}

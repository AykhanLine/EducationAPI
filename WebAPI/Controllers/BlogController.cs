using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet("getallblogs")]
        public List<Blog> GetAllBlogs()
        {
            var blog = _blogService.GetAll()
                if()
        }

        [HttpPost("addblog")]
        public IActionResult AddBlog()
        {

            
        }
    }
}

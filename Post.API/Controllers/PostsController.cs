using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Post.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {

        private List<Post> _posts = new List<Post>();
        
        public PostsController()
        {
            _posts.Add(new Post
            {
                Title = "La lluvia",
                Body = "No para de llover en todo el día"
            });
            _posts.Add(
                new Post
                {
                    Title = "Fútbol",
                    Body = "Podrido de esos partidos al pedo"
                });
        }

        [HttpGet]
        public List<Post> GetPosts()
        {
            return _posts;
        }



        public class Post
        {
            public string Title { get; set; }
            public string Body { get; set; }
        }
    }
}

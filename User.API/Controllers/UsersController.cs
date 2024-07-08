using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private List<User> _users = new List<User>();

        public UsersController()
        {
            _users.Add(new User
            {
                Id = 1,
                UserName = "Nano",
            });
            _users.Add(new User
            {
                Id = 2,
                UserName = "Pepa"
            });
        }


        [HttpGet]
        public List<User> GetUsers()
        {
            return _users;
        }


        public class User
        {
            public int Id { get; set; }
            public string UserName { get; set; }
        }
    }
}

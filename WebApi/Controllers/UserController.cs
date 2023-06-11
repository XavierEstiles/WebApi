using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController: ControllerBase
    {
        private List<User> users = new List<User> 
        {
            new User
            {
                id = 0,
                name = "Test",
                email = "Test",
                mainImage = 1
            },
            new User
            {
                id = 1,
                name = "Test",
                email = "Test",
                mainImage = 1
            },new User
            {
                id = 3,
                name = "Test",
                email = "Test",
                mainImage = 1
            },

        };

        [HttpPost]
        [Route("GetUsers")]
        public dynamic GetUsers() 
        {
            return users;
        }

        [HttpPost]
        [Route("SaveUser")]
        public dynamic SaveUser(User user)
        {
            users.Add(user);
            return users;
        }

        [HttpPost]
        [Route("EditUser")]
        public dynamic EditUser(User user)
        {
            User tmpUser = new User();
            if (user.id < users.Count && (tmpUser = users[user.id]) != null)
            {
                users.Remove(tmpUser);
                users.Add(user);
                return users;
            }
            else 
            {
                return "no esta";
            }
            
            
        }
    }
}

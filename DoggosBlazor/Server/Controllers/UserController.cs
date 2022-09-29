using DoggosBlazor.Server.Models;
using DoggosBlazor.Server.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoggosBlazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
    
        [HttpGet]
        public List<User> GetUsers()
        {
            return userRepository.GetUsers();
        }
    }
}

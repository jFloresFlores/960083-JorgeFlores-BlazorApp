using DoggosBlazor.Server.Data;
using DoggosBlazor.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace DoggosBlazor.Server.Repositories
{
    public interface IUserRepository
    {
        public User saveUserInfo(User user);

        public List<User> GetUsers();

    }
}

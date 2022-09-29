using DoggosBlazor.Server.Data;
using DoggosBlazor.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggosBlazor.Server.Repositories
{
    public class UserRepository : IUserRepository
    {
        private IUserContext _context;

        public UserRepository(IUserContext context)
        {
            _context = context;
        }


        public User saveUserInfo(User user)
        {
            _context.users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public List<User> GetUsers()
        {
            return _context.users.ToList();
        }

    }
}

using DoggosBlazor.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggosBlazor.Server.Data
{
    public interface IUserContext
    {
        public DbSet<User> users { get; set; }

        public void SaveChanges();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleLogin.Models;

namespace SimpleLogin.Data
{
    public class UserContext : DbContext
    {
        public UserContext (DbContextOptions<UserContext> options)
            : base(options)
        {

        }

        public DbSet<SimpleLogin.Models.User> User { get; set; } = default!;
    }
}

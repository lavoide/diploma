using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace diploma.Models
{
    public class UserContext : DbContext  
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options) 
        {
        } 
        public DbSet<User> Users { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
    }
}

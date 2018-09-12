using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace ShirlyStudio.Models
{
    public class ShirlyStudioContext : DbContext
    {
        public ShirlyStudioContext (DbContextOptions<ShirlyStudioContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication4.Models.Workshop> Workshop { get; set; }

        public DbSet<WebApplication4.Models.Teacher> Teacher { get; set; }

        public DbSet<WebApplication4.Models.Customer> Customer { get; set; }

        public DbSet<WebApplication4.Models.Transaction> Transaction { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Rocket_Elevators_REST_API.Models
{
    public class MySqlConnectionContext : DbContext
    {
        public MySqlConnectionContext (DbContextOptions<MySqlConnectionContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> customers { get; set; }

        public DbSet<Battery> batteries { get; set; }

        public DbSet<Building> buildings { get; set; }

        public DbSet<Column> columns { get; set; }

        public DbSet<Elevator> elevators { get; set; }
        public DbSet<Lead> leads { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CarsManagementAPI.Context
{
    public class CarsManagementAPIContext : DbContext
    {
        public CarsManagementAPIContext(DbContextOptions options) : base(options)
        {
            
        }

        public CarsManagementAPIContext()
        {
            
        }

        public DbSet<User> User { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Service> Service { get; set; }
    }
}

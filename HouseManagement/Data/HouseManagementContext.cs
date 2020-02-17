using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HouseManagement.Models;

namespace HouseManagement.Data
{
    public class HouseManagementContext : DbContext
    {
        public HouseManagementContext (DbContextOptions<HouseManagementContext> options)
            : base(options)
        {
        }

        public DbSet<HouseManagement.Models.House> House { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseManagement.Models
{
    public class House
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }

    public class HouseManagementContext : DbContext
    {
        public HouseManagementContext(DbContextOptions<HouseManagementContext> options)
            : base(options)
        {
        }
        public DbSet<HouseManagement.Models.House> House { get; set; }
    }
}

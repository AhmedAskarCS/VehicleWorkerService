using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VehicleWorkerService.Models;

namespace VehicleWorkerService.Services
{
    public class AppDbContext : DbContext
    {
        public DbSet<VehicleLog> VehiclesLog { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
    }
}

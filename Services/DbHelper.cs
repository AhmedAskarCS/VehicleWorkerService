using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleWorkerService.Models;

namespace VehicleWorkerService.Services
{
    public class DbHelper
    {
        private AppDbContext dbContext;

        private DbContextOptions<AppDbContext> GetAllOptions()
        {
            var optionBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionBuilder.UseSqlServer(AppSettings.ConnectionString);
            return optionBuilder.Options;
        }

        //GetAllUser
        public List<VehicleLog> GetAllUser()
        {
            using(dbContext=new AppDbContext(GetAllOptions()))
            {
                try
                {
                    var users = dbContext.VehiclesLog.ToList();
                    if (users != null)
                        return users;
                    else
                        return new List<VehicleLog>();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        //Seed Data
        //Used when no data is present, we want some default data to fill in the Database
        public void SeedData()
        {
            using(dbContext=new AppDbContext(GetAllOptions()))
            {
                dbContext.VehiclesLog.Add(new VehicleLog
                {
                    Name = "Rohit",
                    Address = "Abc Street,Mumbai"
                });
                dbContext.SaveChanges();
            }
        }
    }
}

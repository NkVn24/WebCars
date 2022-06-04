using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebCars.Models;

namespace WebCars.Data
{
    public class WebCarsContext : DbContext
    {
        public WebCarsContext (DbContextOptions<WebCarsContext> options)
            : base(options)
        {
        }

        public DbSet<WebCars.Models.Car>? Car { get; set; }

        public DbSet<WebCars.Models.Truck>? Truck { get; set; }
    }
}

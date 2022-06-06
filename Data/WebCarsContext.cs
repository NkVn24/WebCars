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
		public WebCarsContext(DbContextOptions<WebCarsContext> options)
            : base(options)
        {
        }

        public DbSet<Car>? Cars { get; set; }

        public DbSet<Truck>? Trucks { get; set; }

        public DbSet<Brand> Brands { get; set; }
    }
}

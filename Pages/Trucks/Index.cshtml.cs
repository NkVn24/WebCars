using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebCars.Data;
using WebCars.Models;

namespace WebCars.Pages.Trucks
{
    public class IndexModel : PageModel
    {
        private readonly WebCars.Data.WebCarsContext _context;

        public IndexModel(WebCars.Data.WebCarsContext context)
        {
            _context = context;
        }

        public IList<Truck> Truck { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Truck != null)
            {
                Truck = await _context.Truck.ToListAsync();
            }
        }
    }
}

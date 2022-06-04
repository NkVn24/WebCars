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
    public class DetailsModel : PageModel
    {
        private readonly WebCars.Data.WebCarsContext _context;

        public DetailsModel(WebCars.Data.WebCarsContext context)
        {
            _context = context;
        }

      public Truck Truck { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Truck == null)
            {
                return NotFound();
            }

            var truck = await _context.Truck.FirstOrDefaultAsync(m => m.ID == id);
            if (truck == null)
            {
                return NotFound();
            }
            else 
            {
                Truck = truck;
            }
            return Page();
        }
    }
}

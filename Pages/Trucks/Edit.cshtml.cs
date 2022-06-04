using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCars.Data;
using WebCars.Models;

namespace WebCars.Pages.Trucks
{
    public class EditModel : PageModel
    {
        private readonly WebCars.Data.WebCarsContext _context;

        public EditModel(WebCars.Data.WebCarsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Truck Truck { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Truck == null)
            {
                return NotFound();
            }

            var truck =  await _context.Truck.FirstOrDefaultAsync(m => m.ID == id);
            if (truck == null)
            {
                return NotFound();
            }
            Truck = truck;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Truck).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TruckExists(Truck.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TruckExists(int id)
        {
          return (_context.Truck?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}

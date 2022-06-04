using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebCars.Data;
using WebCars.Models;

namespace WebCars.Pages.Trucks
{
    public class CreateModel : PageModel
    {
        private readonly WebCars.Data.WebCarsContext _context;

        public CreateModel(WebCars.Data.WebCarsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Truck Truck { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Truck == null || Truck == null)
            {
                return Page();
            }

            _context.Truck.Add(Truck);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

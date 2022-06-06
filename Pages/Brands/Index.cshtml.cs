﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebCars.Data;
using WebCars.Models;

namespace WebCars.Pages.Brands
{
    public class IndexModel : PageModel
    {
        private readonly WebCarsContext _context;

        public IndexModel(WebCarsContext context)
        {
            _context = context;
        }

        public IList<Brand> Brand { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Brands != null)
            {
                Brand = await _context.Brands.ToListAsync();
            }
        }
    }
}

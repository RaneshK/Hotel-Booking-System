﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ThreeSistersHotel.Data;
using ThreeSistersHotel.Pages.Models;

namespace ThreeSistersHotel.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly ThreeSistersHotel.Data.ApplicationDbContext _context;

        public DetailsModel(ThreeSistersHotel.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.Email == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

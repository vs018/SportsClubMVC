﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsClub.Models;
using SportsClub.SqlConnection;

namespace SportsClub.Pages.memberPayment
{
    public class CreateModel : PageModel
    {
        private readonly SportsClub.Models.SportsClubContext _context;

        public CreateModel(SportsClub.Models.SportsClubContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Payment Payment { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Payment.Add(Payment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
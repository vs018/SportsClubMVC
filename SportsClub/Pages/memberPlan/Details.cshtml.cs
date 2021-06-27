using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportsClub.Models;
using SportsClub.SqlConnection;

namespace SportsClub.Pages.memberPlan
{
    public class DetailsModel : PageModel
    {
        private readonly SportsClub.Models.SportsClubContext _context;

        public DetailsModel(SportsClub.Models.SportsClubContext context)
        {
            _context = context;
        }

        public Plan Plan { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Plan = await _context.Plan.FirstOrDefaultAsync(m => m.id == id);

            if (Plan == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

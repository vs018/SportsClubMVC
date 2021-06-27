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
    public class IndexModel : PageModel
    {
        private readonly SportsClub.Models.SportsClubContext _context;

        public IndexModel(SportsClub.Models.SportsClubContext context)
        {
            _context = context;
        }

        public IList<Plan> Plan { get;set; }

        public async Task OnGetAsync()
        {
            Plan = await _context.Plan.ToListAsync();
        }
    }
}

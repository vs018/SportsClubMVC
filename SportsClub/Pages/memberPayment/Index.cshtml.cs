using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportsClub.Models;
using SportsClub.SqlConnection;

namespace SportsClub.Pages.memberPayment
{
    public class IndexModel : PageModel
    {
        private readonly SportsClub.Models.SportsClubContext _context;

        public IndexModel(SportsClub.Models.SportsClubContext context)
        {
            _context = context;
        }

        public IList<Payment> Payment { get;set; }

        public async Task OnGetAsync()
        {
            Payment = await _context.Payment.ToListAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HouseManagement.Data;
using HouseManagement.Models;

namespace HouseManagement
{
    public class DetailsModel : PageModel
    {
        private readonly HouseManagement.Data.HouseManagementContext _context;

        public DetailsModel(HouseManagement.Data.HouseManagementContext context)
        {
            _context = context;
        }

        public House House { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            House = await _context.House.FirstOrDefaultAsync(m => m.ID == id);

            if (House == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

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
    public class DeleteModel : PageModel
    {
        private readonly HouseManagement.Data.HouseManagementContext _context;

        public DeleteModel(HouseManagement.Data.HouseManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            House = await _context.House.FindAsync(id);

            if (House != null)
            {
                _context.House.Remove(House);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

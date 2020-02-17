using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HouseManagement.Data;
using HouseManagement.Models;

namespace HouseManagement
{
    public class CreateModel : PageModel
    {
        private readonly HouseManagement.Data.HouseManagementContext _context;

        public CreateModel(HouseManagement.Data.HouseManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public House House { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.House.Add(House);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

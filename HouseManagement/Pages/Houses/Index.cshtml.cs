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
    public class IndexModel : PageModel
    {
        private readonly HouseManagement.Data.HouseManagementContext _context;

        public IndexModel(HouseManagement.Data.HouseManagementContext context)
        {
            _context = context;
        }

        public IList<House> House { get;set; }

        public async Task OnGetAsync()
        {
            House = await _context.House.ToListAsync();
        }
    }
}

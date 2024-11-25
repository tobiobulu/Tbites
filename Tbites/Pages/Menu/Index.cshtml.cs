using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tbites.Data;
using Tbites.Models;

namespace Tbites.Pages.Menu
{
    public class IndexModel : PageModel
    {
        private readonly Tbites.Data.TbitesContext _context;

        public IndexModel(Tbites.Data.TbitesContext context)
        {
            _context = context;
        }

        public IList<FoodItem> FoodItem { get;set; } = default!;

        public async Task OnGetAsync()
        {
            FoodItem = await _context.FoodItems.ToListAsync();
        }
    }
}

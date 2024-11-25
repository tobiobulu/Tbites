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
    public class DetailsModel : PageModel
    {
        private readonly Tbites.Data.TbitesContext _context;

        public DetailsModel(Tbites.Data.TbitesContext context)
        {
            _context = context;
        }

        public FoodItem FoodItem { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fooditem = await _context.FoodItems.FirstOrDefaultAsync(m => m.ID == id);
            if (fooditem == null)
            {
                return NotFound();
            }
            else
            {
                FoodItem = fooditem;
            }
            return Page();
        }
    }
}

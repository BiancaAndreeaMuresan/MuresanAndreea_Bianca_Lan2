using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MuresanAndreea_Bianca_Lan2.Data;
using MuresanAndreea_Bianca_Lan2.Models;

namespace MuresanAndreea_Bianca_Lan2.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly MuresanAndreea_Bianca_Lan2.Data.MuresanAndreea_Bianca_Lan2Context _context;

        public DetailsModel(MuresanAndreea_Bianca_Lan2.Data.MuresanAndreea_Bianca_Lan2Context context)
        {
            _context = context;
        }

      public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}

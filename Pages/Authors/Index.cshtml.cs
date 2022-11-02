using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MuresanAndreea_Bianca_Lan2.Data;
using MuresanAndreea_Bianca_Lan2.Models;

namespace MuresanAndreea_Bianca_Lan2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly MuresanAndreea_Bianca_Lan2.Data.MuresanAndreea_Bianca_Lan2Context _context;

        public IndexModel(MuresanAndreea_Bianca_Lan2.Data.MuresanAndreea_Bianca_Lan2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Author != null)
            {
                Author = await _context.Author.ToListAsync();
            }
        }
    }
}

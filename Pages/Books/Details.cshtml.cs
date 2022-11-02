﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MuresanAndreea_Bianca_Lan2.Data;
using MuresanAndreea_Bianca_Lan2.Models;

namespace MuresanAndreea_Bianca_Lan2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly MuresanAndreea_Bianca_Lan2.Data.MuresanAndreea_Bianca_Lan2Context _context;

        public DetailsModel(MuresanAndreea_Bianca_Lan2.Data.MuresanAndreea_Bianca_Lan2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                Book = book;
            }
            return Page();
        }

    }
}

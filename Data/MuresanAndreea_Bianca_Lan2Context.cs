using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MuresanAndreea_Bianca_Lan2.Models;

namespace MuresanAndreea_Bianca_Lan2.Data
{
    public class MuresanAndreea_Bianca_Lan2Context : DbContext
    {
        public MuresanAndreea_Bianca_Lan2Context (DbContextOptions<MuresanAndreea_Bianca_Lan2Context> options)
            : base(options)
        {
        }

        public DbSet<MuresanAndreea_Bianca_Lan2.Models.Book> Book { get; set; } = default!;

        public DbSet<MuresanAndreea_Bianca_Lan2.Models.Publisher> Publisher { get; set; }
    }
}

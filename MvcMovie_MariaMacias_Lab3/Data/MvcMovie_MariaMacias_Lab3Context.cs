using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie_MariaMacias_Lab3.Models;

namespace MvcMovie_MariaMacias_Lab3.Data
{
    public class MvcMovie_MariaMacias_Lab3Context : DbContext
    {
        public MvcMovie_MariaMacias_Lab3Context (DbContextOptions<MvcMovie_MariaMacias_Lab3Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie_MariaMacias_Lab3.Models.Movie> Movie { get; set; } = default!;
    }
}

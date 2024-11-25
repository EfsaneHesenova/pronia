using Microsoft.EntityFrameworkCore;
using Pronia.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronia.DAL.Contexts
{
    public class ProniaDbContext: DbContext
    {
        public ProniaDbContext(DbContextOptions options) : base(options) { }

        public DbSet<SliderItem> SliderItems { get; set; }
    }
}

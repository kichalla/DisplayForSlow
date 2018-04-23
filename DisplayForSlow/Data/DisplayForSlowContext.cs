using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DisplayForSlow.Models
{
    public class DisplayForSlowContext : DbContext
    {
        public DisplayForSlowContext (DbContextOptions<DisplayForSlowContext> options)
            : base(options)
        {
        }

        public DbSet<DisplayForSlow.Models.Customer> Customer { get; set; }
    }
}

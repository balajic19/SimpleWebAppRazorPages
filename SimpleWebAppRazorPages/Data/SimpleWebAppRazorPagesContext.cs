using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleWebAppRazorPages.Models;

namespace SimpleWebAppRazorPages.Data
{
    public class SimpleWebAppRazorPagesContext : DbContext
    {
        public SimpleWebAppRazorPagesContext (DbContextOptions<SimpleWebAppRazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<SimpleWebAppRazorPages.Models.Movie> Movie { get; set; }
    }
}

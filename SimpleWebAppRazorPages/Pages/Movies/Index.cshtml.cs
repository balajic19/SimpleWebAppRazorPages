using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SimpleWebAppRazorPages.Data;
using SimpleWebAppRazorPages.Models;

namespace SimpleWebAppRazorPages.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly SimpleWebAppRazorPages.Data.SimpleWebAppRazorPagesContext _context;

        public IndexModel(SimpleWebAppRazorPages.Data.SimpleWebAppRazorPagesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}

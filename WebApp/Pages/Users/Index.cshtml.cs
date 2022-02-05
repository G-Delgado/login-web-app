#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public IndexModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        [BindProperty(SupportsGet = true)]
        public string Username { get; set; }
        public string Passwword { get; set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}

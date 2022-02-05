#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Users
{
    public class CreateModel : PageModel
    {
        private readonly WebApp.Data.WebAppContext _context;

        public CreateModel(WebApp.Data.WebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public new User User { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (User.FirstName == null || User.LastName == null || User.BirthDay.Equals(1/01/0001))
            {
                // We need a search method that comes from Index
                // Then redirect to a certain webPage
                if (true) // Instead of true is the result of the search compared to the user Username and Password
                {
                return RedirectToPage("Users/Index");
                }
                else
                {
                    // Stays in the page and lets out a warning
                }
            }
            else
            {
            _context.User.Add(User);
            await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

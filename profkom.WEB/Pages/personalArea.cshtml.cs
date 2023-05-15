using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Kursach.BL.Model;
using Kursach.BL.Controller;

namespace profkom.WEB.Pages
{
    public class personalAreaModel : PageModel
    {
        public Users user { get; set; } = Session.User;
        public void OnGet()
        {
        }
    }
}

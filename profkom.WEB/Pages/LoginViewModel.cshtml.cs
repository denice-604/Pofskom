using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Kursach.BL.Model;
using Kursach.BL.Controller;

namespace profkom.WEB.Pages
{
    [IgnoreAntiforgeryToken]
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Login { get; set; } = "";
        [BindProperty]
        public string Password { get; set; } = "";
        public string ErrorMessage { get; set; } = "";
        public IActionResult OnPost()
        {

            Users? user = Session.Users.SingleOrDefault(u => u.Login == Login);
            if (user == null)
            {
                ErrorMessage = "Логин не найден.";
                return Page();
            }
            if (user.Password != Password) 
            {
                ErrorMessage = "Пароль введён неверно.";
                return Page();
            }

            Session.User = user;

            return RedirectToPagePermanent("Main");
        }
    }
}
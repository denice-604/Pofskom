using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace profkom.WEB.Pages
{
    public class MainModel : PageModel
    {

		public string ErrorMessage { get; set; } = "";
		public void OnGet()
        {
           
        }

        public IActionResult OnPost(string action)
        {


            if (action == "action1")
            {
                return RedirectToPage("ShowMembers");
            }

            else if (action == "action3")
            {
                return RedirectToPage("AddMember");
            }
            else if (action == "DepartList")
            {
                return RedirectToPage("DepartList");
            }
            else if (action == "PostsList")
            {
                return RedirectToPage("PostList");
            }
            else if (action == "UserList")
            {
                return RedirectToPage("UsersList");
            }

            return Page();
        }

    }
}

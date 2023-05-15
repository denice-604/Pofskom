using Kursach.BL.Controller;
using Kursach.BL.Controller.Add;
using Kursach.BL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace profkom.WEB.Pages
{
    public class UsersListModel : PageModel
    {
        [BindProperty]
        public Users? User { get; set; } = null;
        public List<Users> Users { get; set; } = Session.Users;
        public List<Organization> Organizations = Session.Organizations;
        public List<OrgPost> Posts = Session.Posts;
        public void OnGet()
        {
            Organizations = Session.Organizations;
            Posts = Session.Posts;
        }

        public void OnPost()
        {
            if (User != null)
            {
                AddUser.Add(User);
                User = null;
            }
        }



    }
}

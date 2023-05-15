using Kursach.BL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Kursach.BL.Controller;
using Kursach.BL.Controller.Create;

namespace profkom.WEB.Pages
{
    public class AddMemberModel : PageModel
    {

        [BindProperty]
        public Member? Member { get; set; } = null;

        [BindProperty]
        public bool Gender { get; set; }
        public List<Organization> Organizations = Session.Organizations;
        public List<OrgPost> Posts = Session.Posts;
        [BindProperty]
        public bool MaritalStatus { get; set; }
        public string Message { get; set; } = string.Empty;
        public void OnGet()
        {
            Organizations = Session.Organizations;
            Posts = Session.Posts;
        }

        public void OnPost()
        {
            if (Member != null)
            {
                AddPerson.Add(Member);
                Member = null;
            }
        }
    }
}

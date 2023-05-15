using Kursach.BL.Controller;
using Kursach.BL.Controller.Add;
using Kursach.BL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace profkom.WEB.Pages
{
    public class DepartListModel : PageModel
    {
        [BindProperty]
        public Organization? Organization { get; set; } = null;

        public List<Organization> Organizations = Session.Organizations;
        public void OnGet()
        {
            Organizations = Session.Organizations;
        }

        public void OnPost()
        {
            if (Organization != null)
            {
                AddDepartment.Add(Organization);
                Organization = null;
            }
        }
    }
}

using Kursach.BL.Controller;
using Kursach.BL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Dynamic;

namespace profkom.WEB.Pages
{
    public class ShowMembersModel : PageModel
    {

        public List<Member> members = Session.Members;

        public void OnGet() 
        {
            members = Session.Members;
        }


        public string DepartmentOnID (int id)
        {
            Organization? department = Session.Organizations.FirstOrDefault(o => o.Id == id);
            if (department == null)
            {
                return "не найдено";
            }

            return department.Name;
        } 
        
    }
}

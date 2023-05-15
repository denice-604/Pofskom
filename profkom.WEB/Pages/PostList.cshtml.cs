using Kursach.BL.Controller.Add;
using Kursach.BL.Controller;
using Kursach.BL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace profkom.WEB.Pages
{
    public class PostListModel : PageModel
    {
        [BindProperty]
        public OrgPost? Post{ get; set; } = null;

        public List<OrgPost> Posts = Session.Posts;
        public void OnGet()
        {
            Posts = Session.Posts;
        }

        public void OnPost()
        {
            if (Post != null)
            {
                AddDepPost.Add(Post);
                Post = null;
            }
        }
    }
}

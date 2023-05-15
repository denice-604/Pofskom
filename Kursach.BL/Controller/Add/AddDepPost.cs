using Kursach.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.BL.Controller.Add
{
    public class AddDepPost
    {
        public static bool Add(OrgPost orgPost)
        {
            WorkWithDB.AddOrgPost(ref orgPost); 

            Session.Posts.Add(orgPost);

            return true;
        }
    }
}

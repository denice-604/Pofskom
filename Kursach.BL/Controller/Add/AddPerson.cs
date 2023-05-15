using Kursach.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.BL.Controller.Create
{
    public class AddPerson
    {
        public static bool Add(Member member)
        {
            WorkWithDB.AddMember(ref member);

            Session.Members.Add(member);

            return true;
        }
    }
}

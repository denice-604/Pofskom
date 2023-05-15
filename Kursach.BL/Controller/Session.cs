using Kursach.BL.Model;
using System.Collections.Generic;
using System.Data;

namespace Kursach.BL.Controller
{
    public class Session
    {
        public static List<Member> Members = new List<Member>();

        public static List<Organization> Organizations = new List<Organization>();

        public static List<OrgPost> Posts = new List<OrgPost>();

        public static List<Users> Users = new List<Users>();
        public static Users User { get; set; }
        static public void StartSession()
        {
            WorkWithDB.CheckDB();

            WorkWithDB.GetFromDBPostProfk(ref Posts);

            WorkWithDB.GetFromDBOrganization(ref Organizations);

            WorkWithDB.GetFromDBMembers(ref Members);

            WorkWithDB.GetUsersFromDB(ref Users);

        }
    }
}

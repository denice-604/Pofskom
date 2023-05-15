using Kursach.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.BL.Controller.Add
{
    public class AddDepartment
    {
        public static bool Add(Organization organization)
        {
            WorkWithDB.AddOrganization(ref organization);

            Session.Organizations.Add(organization);

            return true;
        }
    }
}

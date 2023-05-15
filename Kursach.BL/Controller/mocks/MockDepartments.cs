using Kursach.BL.Controller.interfaces;
using Kursach.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.BL.Controller.mocks
{
    public class MockDepartments : IDepartments
    {
        public IEnumerable<Organization> AllOrganizations { get => AllOrganizations; set => AllOrganizations = Session.Organizations; }
    }
}

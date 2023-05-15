using Kursach.BL.Controller.interfaces;
using Kursach.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.BL.Controller.mocks
{
    internal class MockMembers : IMembers
    {
        public IEnumerable<Member> AllMembers { get => AllMembers; set => AllMembers = Session.Members; }
    }
}

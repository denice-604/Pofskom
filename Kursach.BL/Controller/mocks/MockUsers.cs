using Kursach.BL.Controller.interfaces;
using Kursach.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kursach.BL.Controller.mocks
{
    internal class MockUsers : IUsers
    {
        public IEnumerable<Users> AllUsers { get => AllUsers; set => AllUsers = Session.Users; }
    }
}

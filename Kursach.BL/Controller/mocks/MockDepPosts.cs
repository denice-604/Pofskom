using Kursach.BL.Controller.interfaces;
using Kursach.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.BL.Controller.mocks
{
    internal class MockDepPosts : IDepPosts
    {
        public IEnumerable<OrgPost> AllorgPosts { get => AllorgPosts; set => AllorgPosts = Session.Posts; }
    }
}

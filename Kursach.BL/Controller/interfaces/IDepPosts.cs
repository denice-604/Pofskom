using Kursach.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.BL.Controller.interfaces
{
    public interface IDepPosts
    {
        IEnumerable<OrgPost> AllorgPosts { get; set; }
    }
}

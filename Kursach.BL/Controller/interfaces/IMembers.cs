using Kursach.BL.Model;
using System.Collections.Generic;

namespace Kursach.BL.Controller.interfaces
{
    public interface IMembers
    {
        IEnumerable<Member> AllMembers { get; set; }
    }
}

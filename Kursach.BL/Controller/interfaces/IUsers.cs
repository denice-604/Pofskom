using Kursach.BL.Model;
using System.Collections.Generic;

namespace Kursach.BL.Controller.interfaces
{
    public interface IUsers
    {
        IEnumerable<Users> AllUsers { get; set; }

    }
}

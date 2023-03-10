using System;
using System.Runtime.InteropServices;

namespace Kursach.BL.Model
{
    internal class Membership
    {
        public int Id { get; set; }
        public DateTime DateJoin { get; set; }
        public Organization Organizations { get; set; }
        public OrgPost Post { get; set; }
        public DateTime Payment { get; set; }


        public List<Deserts> Deserts { get; set; }

        public Membership()
        {
        }

    }
}

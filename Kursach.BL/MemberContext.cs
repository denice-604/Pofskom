using Kursach.BL.Model;
using System.Data.Entity;

namespace Kursach.BL
{

    internal class MemberContext : DbContext
    {
        protected MemberContext() : base("DbConnection") { }

        public DbSet<Children> Childrens { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Deserts> Deserts { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Organization> Organizations { get; set; }

    }
}

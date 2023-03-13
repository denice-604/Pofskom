using Kursach.BL.Model;
using System.Data.Entity;

namespace Kursach.BL
{

    public class MemberContext : DbContext
    {
        public MemberContext() : base("Profk") { }

        public DbSet<Children> Childrens { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Deserts> Deserts { get; set; }
        public DbSet<Family> Families { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                        .HasOptional(c => c.Familys)
                        .WithOptionalPrincipal(o => o.Member);

            modelBuilder.Entity<Member>()
                .HasOptional(o => o.Membership)
                .WithOptionalPrincipal(c => c.Member);
        }
    }
}

using System.Data.Entity;

namespace Kursach.BL
{
    internal class DbConnect : DbContext
    {
        protected DbConnect() : base("DbConnect") { }
    }
}

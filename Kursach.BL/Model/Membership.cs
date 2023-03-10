using System;
using System.Collections.Generic;

namespace Kursach.BL.Model
{
    /// <summary>
    /// Membership.
    /// </summary>
    internal class Membership
    {
        /// <summary>
        /// Membership Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date of joining the org.
        /// </summary>
        public DateTime DateJoin { get; set; }

        /// <summary>
        /// Organization.
        /// </summary>
        public Organization Organizations { get; set; }

        /// <summary>
        /// Member post in org.
        /// </summary>
        public OrgPost Post { get; set; }

        /// <summary>
        /// Last due date for dues.
        /// </summary>
        public DateTime LastPayment { get; set; }


        #region Entity
        public Member Members { get; set; }
        public virtual List<Deserts> Deserts { get; set; }

        #endregion

        public Membership()
        {
        }

    }
}

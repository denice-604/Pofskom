using System;
using System.Collections.Generic;

namespace Kursach.BL.Model
{
    /// <summary>
    /// Membership.
    /// </summary>
    public class Membership
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
        /// Last due date for dues.
        /// </summary>
        public DateTime LastPayment { get; set; }

        public OrgPost PostOrg { get; set; }


        #region Entity
        public int MemberId { get; set; }

        public Member Member { get; set; }

        public  List<Deserts> Deserts { get; set; }

        #endregion

        public Membership()
        {
        }

    }
}

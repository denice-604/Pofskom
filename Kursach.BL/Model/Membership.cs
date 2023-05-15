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
        public DateTime DateJoin { get; set; } = new DateTime();

        /// <summary>
        /// Last due date for dues.
        /// </summary>
        public DateTime LastPayment { get; set; } = new DateTime();


        /// <summary>
        /// Member's post in org.
        /// </summary>
        public int OrganizationID { get; set; }
        public int PostOrgID { get; set; }
        public  List<Deserts> Deserts { get; set; }
        public List<Penalty> Penaltys { get; set; }


    }
}

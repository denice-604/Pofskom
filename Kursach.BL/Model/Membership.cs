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


        /// <summary>
        /// Member's post in org.
        /// </summary>
        public OrgPost PostOrg { get; set; }


        #region Entity
        public int MemberId { get; set; }

        public Member Member { get; set; }

        public  List<Deserts> Deserts { get; set; }

        #endregion

        /// <summary>
        /// Create new membership 
        /// </summary>
        /// <param name="id"> Membership Id. </param>
        /// <param name="dateJoin"> Member date join. </param>
        /// <param name="lastPayment"> Date member's last payment. </param>
        /// <param name="postOrg"> Member's post in org. </param>
        /// <exception cref="ArgumentNullException"> Null check. </exception>
        public Membership(int id, DateTime dateJoin, DateTime lastPayment, OrgPost postOrg)
        {
            Id = id;
            DateJoin = dateJoin;
            LastPayment = lastPayment;
            PostOrg = postOrg ?? throw new ArgumentNullException(nameof(postOrg),"Member's post can't be null.");
        }
    }
}

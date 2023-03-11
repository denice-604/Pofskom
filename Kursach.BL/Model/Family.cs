using System;
using System.Collections.Generic;

namespace Kursach.BL.Model
{
    /// <summary>
    /// inf ab member family.
    /// </summary>
    public class Family
    {
        /// <summary>
        /// Family Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Member mom.
        /// </summary>
        public Parent Mother { get; set; }

        /// <summary>
        /// Member dad.
        /// </summary>
        public Parent Father { get; set; }

        #region Entity

        public int MemberId { get; set; }
        public List<Children> Children { get; set; }
        public Member Member { get; set; }

        #endregion 

        public Family() { }


    }
}

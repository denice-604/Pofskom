using System;
using System.Collections.Generic;

namespace Kursach.BL.Model
{
    /// <summary>
    /// inf ab member family.
    /// </summary>
    internal class Family
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

        public Member Members { get; set; }
        public virtual List<Children> Childrens { get; set; }

        #endregion 

        public Family() { }


    }
}

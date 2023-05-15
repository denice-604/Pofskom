using System;

namespace Kursach.BL.Model
{
    /// <summary>
    /// Some member deserts
    /// </summary>
    public class Deserts
    {
        #region свойства
        /// <summary>
        /// Desert type.
        /// </summary>
        public string DesertTypes { get; set; }

        /// <summary>
        /// For what it was issued.
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Date of merit
        /// </summary>
        public DateTime Date { get; set; }

        public int MemberShipsID { get; set; }
        #endregion
    }
}

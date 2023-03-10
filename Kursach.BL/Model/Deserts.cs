﻿using System;

namespace Kursach.BL.Model
{
    /// <summary>
    /// Some member deserts
    /// </summary>
    internal class Deserts
    {

        #region свойства
        /// <summary>
        /// Desert Id.
        /// </summary>
        public int Id { get; set; }

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
        #endregion

        #region Entity

        public Membership Membership { get; set; }

        #endregion

        public Deserts()
        {

        }

    }
}

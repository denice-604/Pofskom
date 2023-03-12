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

        public int MembershipId { get; set; }
        public Member Member { get; set; }

        #endregion

        /// <summary>
        /// Add new Member desert.
        /// </summary>
        /// <param name="id"> Desert Id. </param>
        /// <param name="desertTypes"> Desert type. </param>
        /// <param name="note"> Expl of the desert. </param>
        /// <param name="date"> Pick-up date. </param>
        /// <exception cref="ArgumentNullException"> Null cexk. </exception>
        public Deserts(int id, string desertTypes, string note, DateTime date)
        {
            Id = id;
            DesertTypes = desertTypes ?? throw new ArgumentNullException(nameof(desertTypes),"Deserts type can't be null.");
            Note = note;
            Date = date;
        }
    }
}

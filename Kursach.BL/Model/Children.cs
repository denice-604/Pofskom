using System;

namespace Kursach.BL.Model
{
    /// <summary>
    /// Member's child.
    /// </summary>
    public class Children
    {
        public string FirstName { get; set; }

        /// <summary>
        /// Child surename.
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// Child patronymic.
        /// </summary>
        public string ThirdName { get; set; }

        /// <summary>
        /// Child birth date.
        /// </summary>
        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        /// <summary>
        /// Some note.
        /// </summary>
        public string Note { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.BL.Model
{
    public class Parent
    {
        /// <summary>
        /// Member name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Member surename.
        /// </summary>
        public string Surename { get; set; }

        /// <summary>
        /// Member patronymic.
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Member gender.
        /// </summary>
        public bool Gender { get; set; }

        /// <summary>
        /// Member phine numper.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Member's date of birth.
        /// </summary>
        public int BirthDate { get; set; }

    }
}

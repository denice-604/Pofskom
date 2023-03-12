using System;

namespace Kursach.BL.Model
{
    /// <summary>
    /// Inf ab member family
    /// </summary>
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

        /// <summary>
        /// Create new Parent.
        /// </summary>
        /// <param name="name"> Parent name. </param>
        /// <param name="surename"> Parent surename. </param>
        /// <param name="patronymic"> Parent patronymic. </param>
        /// <param name="gender"> Parent gender. </param>
        /// <param name="phoneNumber"> Parent's phone number. </param>
        /// <param name="birthDate"> Parent birth date. </param>
        /// <exception cref="ArgumentNullException"> Null check. </exception>
        public Parent(string name, 
            string surename, 
            string patronymic, 
            bool gender, 
            string phoneNumber, 
            int birthDate)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name),"Parent's name can't be null.");
            Surename = surename ?? throw new ArgumentNullException(nameof(surename),"Parent's surename can't be null.");
            Patronymic = patronymic ?? throw new ArgumentNullException(nameof(patronymic), "Parent's patronymic can't be null.");
            Gender = gender;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
        }
    }
}

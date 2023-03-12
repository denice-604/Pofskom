using System;

namespace Kursach.BL.Model
{
    /// <summary>
    /// Member's child.
    /// </summary>
    public class Children
    {
        public int Id { get; set; }
        /// <summary>
        /// Child name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Child surename.
        /// </summary>
        public string Surename { get; set; }

        /// <summary>
        /// Child patronymic.
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Child birth date.
        /// </summary>
        public DateTime BirthDate { get; set; }

        #region Entity

        public int FamilyId { get; set; }
        public Family Family { get; set; }

        #endregion 

        /// <summary>
        /// Create new child.
        /// </summary>
        /// <param name="name"> Kid name. </param>
        /// <param name="surename"></param>
        /// <param name="patronymic"></param>
        /// <param name="birthDate"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Children(string name, string surename, string patronymic, DateTime birthDate)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name),"Имя ребёнка не может быть NULL");
            Surename = surename ?? throw new ArgumentNullException(nameof(surename),"Фамилия ребёнка не может быть NULL");
            Patronymic = patronymic ?? throw new ArgumentNullException(nameof(patronymic),"Отчество ребёнка не может быть NULL");
            BirthDate = birthDate;
        }
    }
}

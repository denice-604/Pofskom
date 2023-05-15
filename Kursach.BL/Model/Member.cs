using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kursach.BL.Model
{
    /// <summary>
    /// Member.
    /// </summary>
    public class Member
    {
        #region свойства

        /// <summary>
        /// Member Id.
        /// </summary>
        public int Id { get; set; }

        #region стабильное
        /// <summary>
        /// Member name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Member surename.
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// Member patronymic.
        /// </summary>
        public string ThirdName { get; set; }

        /// <summary>
        /// Member gender.
        /// </summary>
        public bool Gender { get; set; }
        
        /// <summary>
        /// Member phine numper.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Member marital status.
        /// </summary>
        public bool MaritalStatus { get; set; }

        /// <summary>
        /// Member's date of birth.
        /// </summary>
        public DateTime BirthDate { get; set; } = new DateTime();
        #endregion 

        /// <summary>
        /// addres accoding doc.
        /// </summary>
        public Addres DocumetAddress { get; set; } = new Addres();

        /// <summary>
        /// real addres.
        /// </summary>
        public Addres FactAddress { get; set; } = new Addres();

        #region рабочее

        /// <summary>
        /// Member post.
        /// </summary>
        public WorkPost PostW { get; set; } = new WorkPost();

        /// <summary>
        /// Member photo title.
        /// </summary>
        public byte[] Photo { get; set; }

        /// <summary>
        /// Member education.
        /// </summary>
        public Education Educations { get; set; } = new Education();

        /// <summary>
        /// Member email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Member's file number.
        /// </summary>
        public PersonalFile PersonalFiles { get; set; } = new PersonalFile();

        /// <summary>
        /// Member citizenship.
        /// </summary>
        public string Citizenship { get; set; }
        public Parent Mother { get; set; }
        public Parent Father { get; set; }

        #endregion

        #endregion 

        public List<Children> Childrens { get; set; }
        public Membership Memberships { get; set; } = new Membership();
        
        public Member()
        {

        }



    }
}

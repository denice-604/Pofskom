using System;
using System.Data.Entity;

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
        /// Member marital status.
        /// </summary>
        public bool MaritalStatus { get; set; }

        /// <summary>
        /// Member's date of birth.
        /// </summary>
        public DateTime BirthDate { get; set; }
        #endregion 

        #region прописка по документу
        /// <summary>
        /// Member house number. (documents) 
        /// </summary>
        public string NumberHouseD { get; set; }

        /// <summary>
        /// Member's residence street. (documents)
        /// </summary>
        public string AddressD { get; set; }

        /// <summary>
        /// Member's city of residence. (documents)
        /// </summary>
        public string CityD { get; set; }

        /// <summary>
        /// Member's area of residence. (documents)
        /// </summary>
        public string RegionD { get; set; }

        /// <summary>
        /// Member country of residence. (documents)
        /// </summary>
        public string CountryD { get; set; }
        #endregion

        #region прописка по факту
        /// <summary>
        /// Member house number.
        /// </summary>
        public string NumberHouse { get; set; }

        /// <summary>
        /// Member's residence street. 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Member's city of residence.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Member's area of residence.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Member country of residence. 
        /// </summary>
        public string Country { get; set; }
        #endregion

        #region рабочее

        /// <summary>
        /// Member post.
        /// </summary>
        public string Post { get; set; }

        /// <summary>
        /// Member photo title.
        /// </summary>
        public byte[] Photo { get; set; }

        /// <summary>
        /// Member education.
        /// </summary>
        public string Education { get; set; }

        /// <summary>
        /// Member email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Member's file number.
        /// </summary>
        public string PersonalFileNumber { get; set; }

        /// <summary>
        /// Member citizenship.
        /// </summary>
        public string Citizenship { get; set; }

        #endregion

        #endregion

        #region Entity

        public Family Familys { get; set; }

        public Membership Membership { get; set; }

        #endregion

        public Member(int id, 
                      string name, 
                      string surename, 
                      string patronymic, 
                      bool gender, 
                      string phoneNumber, 
                      bool maritalStatus, 
                      DateTime birthDate, 
                      string numberHouseD, 
                      string addressD, 
                      string cityD, 
                      string regionD, 
                      string countryD, 
                      string numberHouse, 
                      string address, 
                      string city, 
                      string region, 
                      string country, 
                      string post, 
                      byte[] photo, 
                      string education, 
                      string email, 
                      string personalFileNumber, 
                      string citizenship)
        {
            Id = id;
            Name = name;
            Surename = surename;
            Patronymic = patronymic;
            Gender = gender;
            PhoneNumber = phoneNumber;
            MaritalStatus = maritalStatus;
            BirthDate = birthDate;
            NumberHouseD = numberHouseD;
            AddressD = addressD;
            CityD = cityD;
            RegionD = regionD;
            CountryD = countryD;
            NumberHouse = numberHouse;
            Address = address;
            City = city;
            Region = region;
            Country = country;
            Post = post;
            Photo = photo;
            Education = education;
            Email = email;
            PersonalFileNumber = personalFileNumber;
            Citizenship = citizenship;
        }




    }
}

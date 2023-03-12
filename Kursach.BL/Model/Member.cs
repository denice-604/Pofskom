using System;

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


        /// <summary>
        /// Create new member.
        /// </summary>
        /// <param name="id"> Member Id. </param>
        /// <param name="name"> Member name. </param>
        /// <param name="surename"> Member surename. </param>
        /// <param name="patronymic"> Member patrinymic. </param>
        /// <param name="gender"> Member's gender. </param>
        /// <param name="phoneNumber"> Members phone number. </param>
        /// <param name="maritalStatus"> Mamber marital status. </param>
        /// <param name="birthDate"> Member date birth. </param>
        /// <param name="numberHouseD"> Member house nuber according to the document. </param>
        /// <param name="addressD"> Member address accoding to the doc. </param>
        /// <param name="cityD"> Member city accoding to the doc. </param>
        /// <param name="regionD"> Member region accodeng to the doc. </param>
        /// <param name="countryD"> Member country accoding to the doc. </param>
        /// <param name="numberHouse"> Actual member's house number. </param>
        /// <param name="address"> Actual Member address. </param>
        /// <param name="city"> Actual Member city. </param>
        /// <param name="region"> Actual member region. </param>
        /// <param name="country"> Actual member region. </param>
        /// <param name="post"> Member's post at work. </param>
        /// <param name="photo"> Member's photo. </param>
        /// <param name="education"> Member education. </param>
        /// <param name="email"> Member email. </param>
        /// <param name="personalFileNumber"> Member personal file number. </param>
        /// <param name="citizenship"> Member's citizenship. </param>
        /// <exception cref="ArgumentNullException"> Null check. </exception>
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
            Name = name ?? throw new ArgumentNullException(nameof(name),"Member name can't be null.");
            Surename = surename ?? throw new ArgumentNullException(nameof(surename),"Member surename can't be null.");
            Patronymic = patronymic ?? throw new ArgumentNullException(nameof(patronymic), "Member patronymic can't be null.");
            Gender = gender;
            PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber),"Member phone number can't be null.");
            MaritalStatus = maritalStatus;
            BirthDate = birthDate;
            NumberHouseD = numberHouseD ?? throw new ArgumentNullException(nameof(numberHouseD));
            AddressD = addressD ?? throw new ArgumentNullException(nameof(addressD));
            CityD = cityD ?? throw new ArgumentNullException(nameof(cityD));
            RegionD = regionD ?? throw new ArgumentNullException(nameof(regionD));
            CountryD = countryD ?? throw new ArgumentNullException(nameof(countryD));
            NumberHouse = numberHouse ?? throw new ArgumentNullException(nameof(numberHouse));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            City = city ?? throw new ArgumentNullException(nameof(city));
            Region = region ?? throw new ArgumentNullException(nameof(region));
            Country = country ?? throw new ArgumentNullException(nameof(country));
            Post = post ?? throw new ArgumentNullException(nameof(post));
            Photo = photo ?? throw new ArgumentNullException(nameof(photo));
            Education = education ?? throw new ArgumentNullException(nameof(education));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            PersonalFileNumber = personalFileNumber ?? throw new ArgumentNullException(nameof(personalFileNumber));
            Citizenship = citizenship ?? throw new ArgumentNullException(nameof(citizenship));
        }

    }
}

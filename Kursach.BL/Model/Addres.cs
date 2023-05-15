namespace Kursach.BL.Model
{
    public class Addres
    {
        /// <summary>
        /// Member house number.
        /// </summary>
        public string NumberHouse { get; set; }

        /// <summary>
        /// Member's residence street. 
        /// </summary>
        public string Street { get; set; }

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

        /// <summary>
        /// Member apartment number.
        /// </summary>
        public string ApartmentNumber { get; set; }

        /// <summary>
        /// Member poscode.
        /// </summary>
        public string Postcode { get; set; }
    }
}

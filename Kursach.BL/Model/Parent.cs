namespace Kursach.BL.Model
{
    /// <summary>
    /// Inf ab member family
    /// </summary>
    public class Parent
    {
        /// <summary>
        /// Parent name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Parent surename.
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// Parent patronymic.
        /// </summary>
        public string ThirdName { get; set; }

        /// <summary>
        /// Parent gender.
        /// </summary>
        public bool Gender { get; set; }

        /// <summary>
        /// Member phine numper.
        /// </summary>
        public string PhoneNumber { get; set; }
        public string JobTitle { get; set; }
        
    }
}

using System;

namespace Kursach.BL.Model
{
    /// <summary>
    /// Name of org.
    /// </summary>
    public class Organization
    {
        /// <summary>
        /// Org name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Create new Org.
        /// </summary>
        /// <param name="name"> Org name. </param>
        /// <exception cref="ArgumentNullException"> Null check. </exception>
        public Organization(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name), "Organization name can't be null.");
        }
    }
}

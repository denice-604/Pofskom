using System;

namespace Kursach.BL.Model
{
    /// <summary>
    /// Member's post in org.
    /// </summary>
    public class OrgPost
    {
        /// <summary>
        /// Nmae of member's post.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Create new member's post.
        /// </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public OrgPost(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name),"Name of post can't be null");
        }
    }
}

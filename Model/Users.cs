// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Users.cs" company="No company">
// Project: TaskManager
// Last edit: 23.8.2024 by Olivia
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager.Model
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    /// The users.
    /// </summary>
    [Serializable]
    [XmlRoot("Users")]
    public class Users
    {
        #region Properties

        /// <summary>
        /// Gets or sets the users list.
        /// </summary>
        [XmlArrayItem(typeof(User))]
        public List<User> UsersList { get; set; }

        #endregion
    }

    /// <summary>
    /// The user.
    /// </summary>
    [Serializable]
    public class User
    {
        #region Properties

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        [XmlElement("SelectedLocation")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        [XmlElement("Username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [XmlElement("Password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [XmlElement("Name")]
        public string Name { get; set; }

        #endregion
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserData.cs" company="No Company">
//   Project: TaskManager
//   // Last edit: 15.1.2025 by Olivia
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager.DatabaseModel
{
    /// <summary>
    /// The users.
    /// </summary>
    public class UserData
    {
        #region Properties

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; }

        #endregion
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Enums.cs" company="No Company">
// Project: TaskManager
// Last edit: 17.10.2024 by Olivia
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager.Model
{
    /// <summary>
    /// The enums.
    /// </summary>
    public class Enums
    {
        #region Enums

        /// <summary>
        /// The priority.
        /// </summary>
        public enum Priority
        {
            /// <summary>
            /// The low.
            /// </summary>
            Low,

            /// <summary>
            /// The medium.
            /// </summary>
            Medium,

            /// <summary>
            /// The high.
            /// </summary>
            High
        }

        /// <summary>
        /// The status.
        /// </summary>
        public enum Status
        {
            /// <summary>
            /// The open.
            /// </summary>
            Open,

            /// <summary>
            /// The analysis.
            /// </summary>
            Analysis,

            /// <summary>
            /// The in progress.
            /// </summary>
            InProgress,

            /// <summary>
            /// The testing.
            /// </summary>
            Testing,

            /// <summary>
            /// The done.
            /// </summary>
            Done
        }

        #endregion
    }
}
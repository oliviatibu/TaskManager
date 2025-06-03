// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Task.cs" company="No Company">
//   Project: TaskManager
//    // Last edit: 15.1.2025 by Olivia
// </copyright>
// <summary>
//   The tasks.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager.DatabaseModel
{
    /// <summary>
    ///     The tasks.
    /// </summary>
    public class Task
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the task id.
        /// </summary>
        public int TaskId { get; set; }

        /// <summary>
        ///     Gets or sets the task short description.
        /// </summary>
        public string TaskShortDescription { get; set; }

        /// <summary>
        ///     Gets or sets the task description.
        /// </summary>
        public string TaskDescription { get; set; }

        /// <summary>
        ///     Gets or sets the task priority.
        /// </summary>
        public string TaskPriority { get; set; }

        /// <summary>
        ///     Gets or sets the task status.
        /// </summary>
        public string TaskStatus { get; set; }

        /// <summary>
        ///     Gets or sets the task responsible.
        /// </summary>
        public string TaskResponsible { get; set; }

        /// <summary>
        ///     Gets or sets the task location.
        /// </summary>
        public string TaskLocation { get; set; }

        #endregion
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IViewTaskManager.cs" company="No company">
// Project: TaskManager
// Last edit: 27.8.2024 by Olivia
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager.View
{
    using TaskManager.DatabaseModel;

    /// <summary>
    /// The ViewTaskManager interface.
    /// </summary>
    public interface IViewTaskManager
    {
        /// <summary>
        /// The handle load detailed task.
        /// </summary>
        /// <param name="tempTask">
        /// The temp task.
        /// </param>
        void HandleLoadDetailedTask(Task tempTask);

        /// <summary>
        /// The handle reload kanban.
        /// </summary>
        void HandleReloadKanban();
    }
}
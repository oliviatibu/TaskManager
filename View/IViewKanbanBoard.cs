// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IViewKanbanBoard.cs" company="No company">
// Project: TaskManager
// Last edit: 28.8.2024 by Olivia
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager.View
{
    using System.Collections.Generic;

    using TaskManager.DatabaseModel;
    using TaskManager.Model;

    /// <summary>
    /// The ViewKanbanBoard interface.
    /// </summary>
    public interface IViewKanbanBoard
    {
        /// <summary>
        /// The handle update tasks.
        /// </summary>
        /// <param name="updateTasks">
        /// The update tasks.
        /// </param>
        void HandleUpdateTasks(List<Task> updateTasks);
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PresenterTask.cs" company="Conti Temic microelectronic GmbH">
// Project: TaskManager
// Department: AMS VED RD HWS EOB
// Last edit: 27.8.2024 by uif74650
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager.Presenter
{
    #region using directives

    using System.Collections.Generic;

    using TaskManager.DatabaseModel;
    using TaskManager.Model;
    using TaskManager.View;

    #endregion

    /// <summary>
    /// The presenter task.
    /// </summary>
    public class PresenterTask
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PresenterTask"/> class.
        /// </summary>
        public PresenterTask()
        {
            this.Model = new ModelTask();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the view.
        /// </summary>
        public IViewCommonTask View { get; set; }

        /// <summary>
        /// Gets or sets the view task manager.
        /// </summary>
        public IViewTaskManager ViewTaskManager { get; set; }

        /// <summary>
        /// Gets or sets the view task.
        /// </summary>
        public IViewTask ViewTask { get; set; }

        /// <summary>
        /// Gets or sets the view kanban board.
        /// </summary>
        public IViewKanbanBoard ViewKanbanBoard { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        public ModelTask Model { get; set; }

        #endregion

        #region Public methods

        /// <summary>
        /// The get users.
        /// </summary>
        /// <param name="databaseName">
        /// The database name.
        /// </param>
        /// <returns>
        /// The <see>
        ///     <cref>IEnumerable</cref>
        /// </see>
        /// .
        /// </returns>
        public IEnumerable<UserData> GetUsers(string databaseName)
        {
            return this.Model.GetUsers(databaseName);
        }

        /// <summary>
        /// The load detailed task.
        /// </summary>
        /// <param name="task">
        /// The task.
        /// </param>
        /// <param name="data">
        /// The data.
        /// </param>
        public void LoadDetailedTask(string task, List<Task> data)
        {
            var tempTask = this.Model.LoadDetailedTask(task, data);
            this.ViewTaskManager?.HandleLoadDetailedTask(tempTask);
        }

        #endregion

        /// <summary>
        /// The update tasks.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="data">
        /// The data.
        /// </param>
        public void UpdateTasks(string location, List<Task> data)
        {
            var tasks = this.Model.UpdateTasks(location, data);
            this.ViewKanbanBoard?.HandleUpdateTasks(tasks);
        }

        /// <summary>
        /// The go back to tasks.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        /// <param name="location">
        /// The location.
        /// </param>
        public void GoBackToTasks(IEnumerable<Task> data, string location)
        {
            var listOfData = this.Model.GoBackToTasks(data, location);
            this.ViewTaskManager?.HandleReloadKanban();
            this.ViewKanbanBoard?.HandleUpdateTasks(listOfData);
        }

        /// <summary>
        /// The add new task.
        /// </summary>
        /// <param name="newTaskObject">
        /// The new task object.
        /// </param>
        /// <param name="data">
        /// The data.
        /// </param>
        /// <param name="databaseName">
        /// The database name.
        /// </param>
        public void AddNewTask(Task newTaskObject, List<Task> data, string databaseName)
        {
            var newData = this.Model.AddNewTask(newTaskObject, data, databaseName);
            this.ViewKanbanBoard?.HandleUpdateTasks(newData);
        }

        /// <summary>
        /// The get locations.
        /// </summary>
        /// <param name="databaseName">
        /// The database name.
        /// </param>
        /// <returns>
        /// The <see>
        ///     <cref>IEnumerable</cref>
        /// </see>
        /// .
        /// </returns>
        public IEnumerable<Locations> GetLocations(string databaseName)
        {
            return this.Model.GetLocations(databaseName);
        }

        /// <summary>
        /// The get tasks.
        /// </summary>
        /// <param name="databaseName">
        /// The database name.
        /// </param>
        /// <returns>
        /// The <see>
        ///     <cref>IEnumerable</cref>
        /// </see>
        /// .
        /// </returns>
        public List<Task> GetTasks(string databaseName)
        {
            return this.Model.GetTasks(databaseName);
        }

        /// <summary>
        /// The update task in db.
        /// </summary>
        /// <param name="newFind">
        /// The new find.
        /// </param>
        /// <param name="databaseDb">
        /// The database db.
        /// </param>
        public void UpdateTaskInDb(Task newFind, string databaseDb)
        {
            var newData = this.Model.UpdateTaskInDb(newFind, databaseDb);
            //this.ViewKanbanBoard?.HandleUpdateTasks(newData);
        }

        public void DeleteTask(Task task, string databaseDb)
        {
            this.Model.DeleteTask(task, databaseDb);
        }
    }
}
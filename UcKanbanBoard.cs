// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UcKanbanBoard.cs" company="NA">
// Project: TaskManager
// Last edit: 9.10.2024 by Olivia
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager
{
    #region using directives

    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using TaskManager.DatabaseModel;
    using TaskManager.Presenter;
    using TaskManager.View;

    #endregion

    /// <summary>
    ///     The uc kanban board.
    /// </summary>
    public partial class UcKanbanBoard : UserControl, IViewCommonTask, IViewKanbanBoard
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UcKanbanBoard"/> class.
        /// </summary>
        public UcKanbanBoard()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the presenter task.
        /// </summary>
        public PresenterTask PresenterTask { get; set; }

        #endregion

        #region Public methods

        /// <summary>
        /// The handle update tasks.
        /// </summary>
        /// <param name="updateTasks">
        /// The update tasks.
        /// </param>
        public void HandleUpdateTasks(List<Task> updateTasks)
        {
            this.PnlTblTasks.Controls.Clear();
            foreach (var taskData in updateTasks)
            {
                var task = new UcTask();
                task.TaskShortDescription = taskData.TaskShortDescription;
                task.TaskPriority = taskData.TaskPriority;
                task.TaskStatus = taskData.TaskStatus;
                task.TaskResponsible = taskData.TaskResponsible;
                task.TaskLocation = taskData.TaskLocation;
                task.Dock = DockStyle.Fill;
                task.SetPresenter(this.PresenterTask);
                this.PnlTblTasks.Controls.Add(task);
            }
        }

        /// <summary>
        /// The set presenter.
        /// </summary>
        /// <param name="presenter">
        /// The presenter.
        /// </param>
        public void SetPresenter(PresenterTask presenter)
        {
            this.PresenterTask = presenter;
            if (presenter == null)
            {
            }

            this.PresenterTask.ViewKanbanBoard = this;
        }

        #endregion

        #region Private methods

        /// <summary>
        /// The add task control.
        /// </summary>
        /// <param name="task">
        /// The task.
        /// </param>
        private void AddTaskControl(Task task)
        {
            var taskControl = new UcTask();
            taskControl.SetPresenter(this.PresenterTask);
            taskControl.TaskShortDescription = task.TaskShortDescription;
            taskControl.TaskPriority = task.TaskPriority;
            taskControl.TaskStatus = task.TaskStatus;
            taskControl.TaskResponsible = task.TaskResponsible;
            taskControl.TaskLocation = task.TaskLocation;
            taskControl.Dock = DockStyle.Fill;
            this.PnlTblTasks.Controls.Add(taskControl);
        }

        /// <summary>
        /// The uc kanban board_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void UcKanbanBoard_Load(object sender, EventArgs e)
        {
            var tasks = this.PresenterTask.GetTasks("Database.db");
            foreach (var task in tasks)
            {
                if (task.TaskLocation == UcLocations.SelectedLocation)
                {
                    this.AddTaskControl(task);
                }
                else if (UcLocations.SelectedLocation == @"All Locations")
                {
                    this.AddTaskControl(task);
                }
            }
        }

        #endregion
    }
}
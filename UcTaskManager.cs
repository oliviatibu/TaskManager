// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UcTaskManager.cs" company="NA">
// Project: TaskManager
// Last edit: 16.1.2025 by Olivia
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager
{
    #region using directives

    using System;
    using System.Drawing;
    using System.Windows.Forms;

    using TaskManager.DatabaseModel;
    using TaskManager.Presenter;
    using TaskManager.View;

    #endregion

    /// <summary>
    /// The uc task manager.
    /// </summary>
    public partial class UcTaskManager : UserControl, IViewTaskManager
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UcTaskManager"/> class.
        /// </summary>
        public UcTaskManager()
        {
            this.InitializeComponent();
            this.PresenterTask = new PresenterTask { ViewTaskManager = this };

            this.Locations.SetPresenter(this.PresenterTask);

            var control = new UcLogin();
            control.LoginButtonClicked += this.UcLogin_LoginButtonClicked;
            this.SplitMain.Panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            this.SplitMain.Panel2.Controls.Add(control);
            control.SetPresenter(this.PresenterTask);
            this.Locations.LocationChanged += this.OnLocationChanged;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the presenter task.
        /// </summary>
        private PresenterTask PresenterTask { get; }

        #endregion

        #region Public methods

        /// <summary>
        /// The handle load detailed task.
        /// </summary>
        /// <param name="task">
        /// The task.
        /// </param>
        public void HandleLoadDetailedTask(Task task)
        {
            var control = new UcDetailedTask();
            control.TaskShortDescription = task.TaskShortDescription;
            control.TaskLongDescription = task.TaskDescription;
            control.TaskResponsible = task.TaskResponsible;
            control.TaskPriority = task.TaskPriority;
            control.TaskStatus = task.TaskStatus;
            control.TaskLocation = task.TaskLocation;
            control.Dock = DockStyle.Fill;
            control.Size = this.SplitMain.Panel2.Size;
            this.SplitMain.Panel2.Controls.Clear();
            control.SetPresenter(this.PresenterTask);
            this.SplitMain.Panel2.Controls.Add(control);
        }

        /// <summary>
        /// The handle reload kanban.
        /// </summary>
        public void HandleReloadKanban()
        {
            var control = new UcKanbanBoard();
            this.SplitMain.Panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.SetPresenter(this.PresenterTask);
            this.SplitMain.Panel2.Controls.Add(control);
        }

        #endregion

        #region Private methods

        /// <summary>
        /// The btn add task_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            this.PnlKanbanActiveRight.BackColor = Color.White;
            this.PnlKanbanActiveUp.BackColor = Color.White;
            this.PnlAddTaskActiveRight.BackColor = Color.Gray;
            this.PnlAddTaskActiveUp.BackColor = Color.Gray;
            var form = new NewTaskForm();
            var newTaskControl = new UcAddTask();
            newTaskControl.SetPresenter(this.PresenterTask);
            newTaskControl.Dock = DockStyle.Fill;
            form.Controls.Add(newTaskControl);
            form.Show();
        }

        /// <summary>
        /// The btn kanban board_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnKanbanBoard_Click(object sender, EventArgs e)
        {
            this.PnlAddTaskActiveRight.BackColor = Color.White;
            this.PnlAddTaskActiveUp.BackColor = Color.White;
            this.PnlKanbanActiveRight.BackColor = Color.Gray;
            this.PnlKanbanActiveUp.BackColor = Color.Gray;
            this.LoadKanBan();
        }

        /// <summary>
        /// The btn login_click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (this.BtnLogin.Text == @"Log out")
            {
                this.PnlAddTaskActiveRight.BackColor = Color.White;
                this.PnlAddTaskActiveUp.BackColor = Color.White;
                this.PnlKanbanActiveRight.BackColor = Color.White;
                this.PnlKanbanActiveUp.BackColor = Color.White;

                this.LblUsername.Text = @"Username";
                this.BtnLogin.Text = @"Login";
                this.BtnAddTask.Enabled = false;
                this.BtnKanbanBoard.Enabled = false;
            }

            this.SplitMain.Panel2.Controls.Clear();
            var control = new UcLogin();
            control.LoginButtonClicked += this.UcLogin_LoginButtonClicked;
            control.Dock = DockStyle.Fill;
            control.Size = this.SplitMain.Panel2.Size;
            control.SetPresenter(this.PresenterTask);
            this.SplitMain.Panel2.Controls.Add(control);
        }

        /// <summary>
        /// The load kan ban.
        /// </summary>
        private void LoadKanBan()
        {
            var control = new UcKanbanBoard();
            this.SplitMain.Panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.SetPresenter(this.PresenterTask);
            this.SplitMain.Panel2.Controls.Clear();
            this.SplitMain.Panel2.Controls.Add(control);
        }

        /// <summary>
        /// The on location changed.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        private void OnLocationChanged(string location)
        {
            var data = this.PresenterTask.GetTasks("Database.db");
            this.PresenterTask.UpdateTasks(location, data);
        }

        /// <summary>
        /// The uc login_ login button clicked.
        /// </summary>
        /// <param name="username">
        /// The username.
        /// </param>
        private void UcLogin_LoginButtonClicked(string username)
        {
            this.BtnLogin.Text = this.BtnLogin.Text == @"Log out" ? @"Login" : @"Log out";
            this.PnlKanbanActiveRight.BackColor = Color.Gray;
            this.PnlKanbanActiveUp.BackColor = Color.Gray;
            this.LoadKanBan();
            this.LblUsername.Text = username;
            this.LblErrorMessages.Text = string.Empty;
            this.BtnAddTask.Enabled = true;
            this.BtnKanbanBoard.Enabled = true;
        }

        /// <summary>
        /// The uc task manager_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void UcTaskManager_Load(object sender, EventArgs e)
        {
            this.BtnAddTask.Enabled = false;
            this.BtnKanbanBoard.Enabled = false;
        }

        #endregion
    }
}
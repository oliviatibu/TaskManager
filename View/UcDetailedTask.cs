// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UcDetailedTask.cs" company="Conti Temic microelectronic GmbH">
// Project: TaskManager
// Department: AMS VED RD HWS EOB
// Last edit: 16.1.2025 by uif74650
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager.View
{
    #region using directives

    #region using directives

    using System;
    using System.Linq;
    using System.Windows.Forms;

    using TaskManager.Model;
    using TaskManager.Presenter;

    #endregion

    #endregion

    /// <summary>
    ///     The uc detailed task.
    /// </summary>
    public partial class UcDetailedTask : UserControl, IViewCommonTask
    {
        #region Fields

        /// <summary>
        ///     The task description.
        /// </summary>
        private string taskDescription;

        /// <summary>
        ///     The task name.
        /// </summary>
        private string taskName;

        /// <summary>
        ///     The task priority.
        /// </summary>
        private string taskPriority;

        /// <summary>
        ///     The task responsible.
        /// </summary>
        private string taskResponsible;

        /// <summary>
        ///     The task status.
        /// </summary>
        private string taskStatus;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="UcDetailedTask" /> class.
        /// </summary>
        public UcDetailedTask()
        {
            this.InitializeComponent();
            this.DdlPriority.DataSource = Enum.GetValues(typeof(Enums.Priority));
            this.DdlStatus.DataSource = Enum.GetValues(typeof(Enums.Status));
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the presenter.
        /// </summary>
        public PresenterTask Presenter { get; set; }

        /// <summary>
        ///     Gets or sets the task short description.
        /// </summary>
        public string TaskShortDescription
        {
            get => this.taskName;
            set
            {
                this.taskName = value;
                this.TbShortDescription.Text = value;
            }
        }

        /// <summary>
        ///     Gets or sets the task location.
        /// </summary>
        public string TaskLocation { get; set; }

        /// <summary>
        ///     Gets or sets the task long description.
        /// </summary>
        public string TaskLongDescription
        {
            get => this.taskDescription;
            set
            {
                this.taskDescription = value;
                this.TxtLongDescription.Text = value;
            }
        }

        /// <summary>
        ///     Gets or sets the task priority.
        /// </summary>
        public string TaskPriority
        {
            get => this.taskPriority;
            set
            {
                this.taskPriority = value;
                this.DdlPriority.Text = value;
            }
        }

        /// <summary>
        ///     Gets or sets the task status.
        /// </summary>
        public string TaskStatus
        {
            get => this.taskStatus;
            set
            {
                this.taskStatus = value;
                this.DdlStatus.Text = value;
            }
        }

        /// <summary>
        ///     Gets or sets the task responsible.
        /// </summary>
        public string TaskResponsible
        {
            get => this.taskResponsible;
            set
            {
                this.taskResponsible = value;
                this.DdlResponsible.Text = value;
            }
        }

        #endregion

        #region Public methods

        /// <summary>
        ///     The set presenter.
        /// </summary>
        /// <param name="presenter">
        ///     The presenter.
        /// </param>
        public void SetPresenter(PresenterTask presenter)
        {
            this.Presenter = presenter;
            if (presenter == null)
            {
                return;
            }

            this.Presenter.View = this;
            this.GetCurrentLocationUsers();
        }

        #endregion

        /// <summary>
        ///     The btn back_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void BtnBack_Click(object sender, EventArgs e)
        {
            var taskModel = this.Presenter.GetTasks("Database.db");
            foreach (var task in taskModel)
            {
                if (task.TaskShortDescription == this.TaskShortDescription)
                {
                    task.TaskShortDescription = this.TbShortDescription.Text;
                    task.TaskStatus = this.DdlStatus.Text;
                    task.TaskPriority = this.DdlPriority.Text;
                    task.TaskResponsible = this.DdlResponsible.Text;
                    task.TaskDescription = this.TxtLongDescription.Text;
                    this.Presenter.UpdateTaskInDb(task, "Database.db");
                    break;
                }
            }
         
            this.Presenter.GoBackToTasks(taskModel, UcLocations.SelectedLocation);
        }

        /// <summary>
        /// The get current location users.
        /// </summary>
        private void GetCurrentLocationUsers()
        {
            var users = this.Presenter.GetUsers("database.db");

            if (UcLocations.SelectedLocation == "All Locations")
            {
                this.DdlResponsible.DataSource = users.Select(x => x.Username).ToList();
            }
            else
            {
                this.DdlResponsible.DataSource = users.Where(x => x.Location == UcLocations.SelectedLocation)
                                                      .Select(x => x.Username).ToList();
            }
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UcTask.cs" company="No Company">
// Project: TaskManager
// Last edit: 28.10.2024 by Olivia
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager.View
{
    #region using directives

    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    using TaskManager.Model;
    using TaskManager.Presenter;

    using Telerik.WinControls.UI;

    #endregion

    /// <summary>
    ///     The uc task.
    /// </summary>
    public partial class UcTask : UserControl, IViewCommonTask, IViewTask
    {
        #region Fields

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
        ///     Initializes a new instance of the <see cref="UcTask" /> class.
        /// </summary>
        public UcTask()
        {
            this.InitializeComponent();
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
                this.LblDescription.Text = value;
            }
        }

        /// <summary>
        ///     Gets or sets the task location.
        /// </summary>
        public string TaskLocation { get; set; }

        /// <summary>
        ///     Gets or sets the task priority.
        /// </summary>
        public string TaskPriority
        {
            get => this.taskPriority;
            set
            {
                this.taskPriority = value;
                this.LblPriority.Text = value;
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
                this.LblStatus.Text = value;
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
        ///     The set column background color.
        /// </summary>
        /// <param name="color">
        ///     The color.
        /// </param>
        public void SetColumnBackgroundColor(Color color)
        {
            for (var row = 0; row < this.PnlTblTaskElements.RowCount; row++)
            {
                var control = this.PnlTblTaskElements.GetControlFromPosition(2, row);
                if (control != null)
                {
                    control.BackColor = color;
                }
            }
        }

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

        #region Private methods

        /// <summary>
        ///     The ddl responsible_ selected value changed.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void DdlResponsible_SelectedValueChanged(object sender, EventArgs e)
        {
            var taskModel = this.Presenter.GetTasks("Database.db");
            foreach (var task in taskModel)
            {
                task.TaskResponsible = this.DdlResponsible.Text;
                this.Presenter.UpdateTaskInDb(task, "Database.db");
                break;
            }
        }

        /// <summary>
        ///     The pnl tbl task elements_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void PnlTblTaskElements_Click(object sender, EventArgs e)
        {
            var tableLayoutPanel = (TableLayoutPanel)sender;
            var parentContainer = tableLayoutPanel.DataBindings.Control;
            var task = parentContainer?.Controls.OfType<RadLabel>()
                                      .FirstOrDefault(label => label.Name == "LblDescription")?.Text;
            var data = this.Presenter.GetTasks("Database.db");

            this.Presenter.LoadDetailedTask(task, data);
        }

        /// <summary>
        ///     The uc task_ load.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void UcTask_Load(object sender, EventArgs e)
        {
            if (!Enum.TryParse(this.TaskPriority, true, out Enums.Priority priority))
            {
                return;
            }

            switch (priority)
            {
                case Enums.Priority.High:
                    this.SetColumnBackgroundColor(Color.Red);
                    break;
                case Enums.Priority.Medium:
                    this.SetColumnBackgroundColor(Color.Yellow);
                    break;
                case Enums.Priority.Low:
                    this.SetColumnBackgroundColor(Color.Green);
                    break;
                default:
                    this.SetColumnBackgroundColor(Color.Gray);
                    break;
            }
        }

        /// <summary>
        /// The get current location users.
        /// </summary>
        private void GetCurrentLocationUsers()
        {
            var users = this.Presenter.GetUsers("database.db");
            var usersList = users.ToList();
          
                if (UcLocations.SelectedLocation == "All Locations")
                {
                    this.DdlResponsible.DataSource = usersList.Select(x => x.Username).ToList();
                }
                else
                {
                    this.DdlResponsible.DataSource = usersList.Where(x => x.Location == UcLocations.SelectedLocation)
                                                              .Select(x => x.Username).ToList();
                }
        }

        #endregion

        private void PictureDelete_Click(object sender, EventArgs e)
        {
            var tableLayoutPanel = (TableLayoutPanel)sender;
            var parentContainer = tableLayoutPanel.DataBindings.Control;
            var taskClicked = parentContainer?.Controls.OfType<RadLabel>()
                                      .FirstOrDefault(label => label.Name == "LblDescription")?.Text;

            var tasks = this.Presenter.GetTasks("Database.db");
            foreach (var task in tasks)
            {
                if (task.TaskShortDescription == this.TaskShortDescription)
                {
                    this.Presenter.DeleteTask(task, "Database.db");
                }
            }
        }
    }
}
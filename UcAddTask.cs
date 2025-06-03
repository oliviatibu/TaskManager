// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UcAddTask.cs" company="NA">
// Project: TaskManager
// Last edit: 28.10.2024 by Olivia
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager
{
    #region using directives

    using System;
    using System.Linq;
    using System.Windows.Forms;

    using TaskManager.DatabaseModel;
    using TaskManager.Model;
    using TaskManager.Presenter;
    using TaskManager.View;

    #endregion

    /// <summary>
    ///     The uc add task.
    /// </summary>
    public partial class UcAddTask : UserControl, IViewCommonTask
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="UcAddTask" /> class.
        /// </summary>
        public UcAddTask()
        {
            this.InitializeComponent();
            this.DdlPriority.DataSource = Enum.GetValues(typeof(Enums.Priority));
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the presenter.
        /// </summary>
        public PresenterTask Presenter { get; set; }

        #endregion

        #region Public methods

        /// <summary>
        ///     The generate unique id.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        public int GenerateUniqueId()
        {
            var tasks = this.Presenter.GetTasks("Database.db");
            var random = new Random();
            int newId;
            bool idExists;

            do
            {
                newId = random.Next(1, 10000);
                idExists = false;

                foreach (var task in tasks)
                {
                    if (task.TaskId == newId)
                    {
                        idExists = true;
                        break;
                    }
                }
            }
            while (idExists);

            return newId;
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

            var users = this.Presenter.GetUsers("Database.db");
            var usersList = users.ToList();
            this.DdlResponsible.DataSource = usersList.Select(x => x.Username).ToList();
        }

        #endregion

        #region Private methods

        /// <summary>
        ///     The btn add task_ click.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            var users = this.Presenter.GetUsers("Database.db");
            var usersList = users.ToList();

            var newTaskObject = new Task
                                    {
                                        TaskShortDescription = this.TbShortDescription.Text,
                                        TaskPriority = this.DdlPriority.Text,
                                        TaskStatus = Enums.Status.Open.ToString(),
                                        TaskResponsible = this.DdlResponsible.Text,
                                        TaskLocation =
                                            usersList.Find(x => x.Username == this.DdlResponsible.Text).Location,
                                        TaskDescription = this.TbRequirements.Text,
                                        TaskId = this.GenerateUniqueId()
                                    };

            var data = this.Presenter.GetTasks("Database.db");
            this.Presenter.AddNewTask(newTaskObject, data, "Database.db");
            var result = MessageBox.Show(
                @"Task successfully added. Would you like to add another task?",
                @"Task Added",
                MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.Yes:
                    this.ClearInputFields();
                    break;
                case DialogResult.No:
                    {
                        var parentForm = this.ParentForm;
                        parentForm?.Close();
                        break;
                    }
            }
        }

        /// <summary>
        ///     The clear input fields.
        /// </summary>
        private void ClearInputFields()
        {
            this.TbRequirements.Text = string.Empty;
            this.TbShortDescription.Text = string.Empty;
            this.DdlPriority.SelectedIndex = -1;
            this.DdlResponsible.SelectedIndex = -1;
        }

        #endregion
    }
}
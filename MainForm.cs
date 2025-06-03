// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="NA">
// Project: TaskManager
// Last edit: 28.10.2024 by Olivia
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager
{
    #region using directives

    using System;
    using System.Windows.Forms;

    #endregion

    /// <summary>
    ///     The main form.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="MainForm" /> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Private methods

        /// <summary>
        /// The main form_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            var taskManager = new UcTaskManager();
            this.Controls.Clear();
            this.Controls.Add(taskManager);
            taskManager.Dock = DockStyle.Fill;
        }

        #endregion
    }
}
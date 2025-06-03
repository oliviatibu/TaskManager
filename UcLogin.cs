// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UcLogin.cs" company="NA">
// Project: TaskManager
// Last edit: 16.1.2025 by Olivia
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager
{
    #region using directives

    using System;
    using System.Windows.Forms;

    using TaskManager.Presenter;
    using TaskManager.View;

    using Telerik.WinControls;

    #endregion

    /// <summary>
    /// The uc login.
    /// </summary>
    public partial class UcLogin : UserControl, IViewCommonTask
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UcLogin"/> class.
        /// </summary>
        public UcLogin()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Delegates

        /// <summary>
        /// The login button clicked handler.
        /// </summary>
        /// <param name="username">
        /// The username.
        /// </param>
        public delegate void LoginButtonClickedHandler(string username);

        #endregion

        #region Events

        /// <summary>
        /// The login button clicked.
        /// </summary>
        public event LoginButtonClickedHandler LoginButtonClicked;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the presenter.
        /// </summary>
        public PresenterTask Presenter { get; set; }

        #endregion

        #region Public methods

        /// <summary>
        /// The set presenter.
        /// </summary>
        /// <param name="presenter">
        /// The presenter.
        /// </param>
        public void SetPresenter(PresenterTask presenter)
        {
            this.Presenter = presenter;
        }

        #endregion

        #region Private methods

        /// <summary>
        /// The btn login_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var usersList = this.Presenter.GetUsers("Database.db");
            foreach (var user in usersList)
            {
                if (this.TxtUserName.Text == user.Username || this.TxtPassword.Text == user.Password)
                {
                    this.LoginButtonClicked?.Invoke(this.TxtUserName.Text);
                    break;
                }

                this.LblError.Text = @"Username or password incorrect!";
            }
        }

        /// <summary>
        /// The txt password_ text changing.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TxtPassword_TextChanging(object sender, TextChangingEventArgs e)
        {
            this.LblError.Text = string.Empty;
        }

        /// <summary>
        /// The txt user name_ text changing.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TxtUserName_TextChanging(object sender, TextChangingEventArgs e)
        {
            this.LblError.Text = string.Empty;
        }

        #endregion
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UcLocations.cs" company="NA">
// Project: TaskManager
// Last edit: 28.10.2024 by Olivia
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager
{
    #region using directives

    using System;
    using System.Windows.Forms;

    using TaskManager.Presenter;
    using TaskManager.View;

    using Telerik.WinControls.UI.Data;

    #endregion

    /// <summary>
    /// The uc locations.
    /// </summary>
    public partial class UcLocations : UserControl, IViewCommonTask
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UcLocations"/> class.
        /// </summary>
        public UcLocations()
        {
            this.InitializeComponent();
            this.InvokeActive = true;
        }

        #endregion

        #region Delegates

        /// <summary>
        /// The location selection changed.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        public delegate void LocationSelectionChanged(string location);

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        public static new string SelectedLocation { get; set; }

        /// <summary>
        /// Gets or sets the location changed.
        /// </summary>
        public new LocationSelectionChanged LocationChanged { get; set; }

        /// <summary>
        /// Gets or sets the presenter.
        /// </summary>
        public PresenterTask Presenter { get; set; }

        /// <summary>
        /// Gets a value indicating whether invoke active.
        /// </summary>
        private bool InvokeActive { get; }

        #endregion

        #region Public methods

        /// <summary>
        /// The on location changed.
        /// </summary>
        /// <param name="location">
        /// The location.
        /// </param>
        public void OnLocationChanged(string location)
        {
            if (this.InvokeActive)
            {
                this.LocationChanged?.Invoke(location);
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
            this.Presenter = presenter;
        }

        #endregion

        #region Private methods

        /// <summary>
        /// The ddl locations_ selected index changed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void DdlLocations_SelectedIndexChanged(
            object sender,
            PositionChangedEventArgs e)
        {
            SelectedLocation = this.DdlLocations.Text;
            this.OnLocationChanged(SelectedLocation);
        }

        /// <summary>
        /// The uc locations_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void UcLocations_Load(object sender, EventArgs e)
        {
            var loc = this.Presenter.GetLocations("Database.db");
            foreach (var location in loc)
            {
                this.DdlLocations.Items.Add(location.City);
            }

            this.DdlLocations.Text = @"All Locations";
            this.OnLocationChanged(this.DdlLocations.Text);
        }

        #endregion
    }
}
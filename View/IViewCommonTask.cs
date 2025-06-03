// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IViewCommonTask.cs" company="No company">
// Project: TaskManager
// Last edit: 27.8.2024 by Olivia
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager.View
{
    #region using directives

    using TaskManager.Presenter;

    #endregion

    /// <summary>
    /// The ViewCommonTask interface.
    /// </summary>
    public interface IViewCommonTask
    {
        #region Public methods

        /// <summary>
        ///     Sets the PCB v6 presenter.
        /// </summary>
        /// <param name="presenter">
        ///     The specified presenter.
        /// </param>
        void SetPresenter(PresenterTask presenter);

        #endregion
    }
}
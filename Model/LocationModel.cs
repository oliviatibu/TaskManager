// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationModel.cs" company="No company">
// Project: TaskManager
// Last edit: 23.8.2024 by Olivia
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace TaskManager.Model
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    /// <summary>
    ///     The location model.
    /// </summary>
    [Serializable]
    [XmlRoot("LocationModel")]
    public class LocationModel
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the location list.
        /// </summary>
        [XmlArrayItem(typeof(Location))]
        public List<Location> LocationList { get; set; }

        #endregion
    }

    /// <summary>
    ///     The location.
    /// </summary>
    [Serializable]
    public class Location
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the city.
        /// </summary>
        [XmlElement("City")]
        public string City { get; set; }

        /// <summary>
        ///     Gets or sets the office.
        /// </summary>
        [XmlElement("Office")]
        public string Office { get; set; }

        #endregion
    }
}
using System.Collections.Generic;

namespace Scrips.Analytics
{
    /// <summary>
    /// Represents an abstract base class for analytics events.
    /// </summary>
    /// <remarks>
    /// This class is intended to be inherited and implemented by concrete analytics event classes.
    /// Each implementation must define the event's name and a method to convert the event's data into a dictionary format.
    /// </remarks>
    public abstract class AnalyticsEvent
    {
        #region Properties

        /// <summary>
        /// Gets the name of the analytic event.
        /// </summary>
        /// <remarks>
        /// This property is used to identify the type or category of the analytic event.
        /// Implementations of this property should return a unique, string identifier
        /// representing the specific analytic event being tracked.
        /// </remarks>
        public abstract string Name { get; }

        #endregion

        #region Methods

        /// Converts the current analytics event to a dictionary representation.
        /// This method is abstract and must be implemented by derived classes to map
        /// all relevant properties of the event to a key-value pair structure.
        /// <returns>A dictionary containing key-value pairs representing
        /// the properties of the analytics event.</returns>
        public abstract Dictionary<string, object> ToDictionary();

        #endregion
    }
}
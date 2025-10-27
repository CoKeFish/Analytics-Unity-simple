using System.Collections.Generic;

namespace Scrips.Analytics.Events
{
    /// <summary>
    /// Represents the MyEvent analytics event.
    /// </summary>
    /// <remarks>
    /// This class extends the AnalyticsEvent base class, and it defines the specific properties and behavior
    /// for the "myEvent" event. The event includes parameters such as a boolean, an integer, a float, and a string.
    /// These parameters are converted into a dictionary format through the overridden ToDictionary method.
    /// </remarks>
    public class MyEvent : AnalyticsEvent
    {
        #region Properties

        /// <summary>
        /// Gets or sets a boolean parameter associated with the analytics event.
        /// </summary>
        /// <remarks>
        /// This property represents a boolean value that can be included in the analytics event data.
        /// It is serialized and sent as part of the event's dictionary representation.
        /// </remarks>
        public bool ParamBool { get; set; }

        /// <summary>
        /// Gets or sets the float parameter associated with the "myEvent" analytics event.
        /// </summary>
        /// <remarks>
        /// This property represents a floating-point value that is included as one of the parameters
        /// for the "myEvent" event. It can be used to capture and track numerical data with decimal precision
        /// in analytics tracking systems.
        /// </remarks>
        public float ParamFloat { get; set; }

        /// <summary>
        /// Gets or sets the integer parameter associated with the "myEvent" analytics event.
        /// </summary>
        /// <remarks>
        /// This property represents a customizable integer value that can be included in the event data
        /// when the "myEvent" event is tracked. It is serialized into a dictionary format for processing
        /// by the analytics service.
        /// </remarks>
        public int ParamInt { get; set; }

        /// <summary>
        /// Gets or sets the string parameter associated with the analytics event.
        /// </summary>
        /// <remarks>
        /// This property represents an optional string value that provides additional
        /// information for the "myEvent" event. The value is included in the event's
        /// dictionary representation as the "paramString" key.
        /// </remarks>
        public string ParamString { get; set; }

        /// <summary>
        /// Gets the name of the analytics event.
        /// </summary>
        /// <remarks>
        /// This property represents a unique string identifier for the event. It is used to
        /// differentiate this event from others within the analytics system. The value of this
        /// property is typically serialized and sent to the analytics service when the event is tracked.
        /// </remarks>
        public override string Name => "myEvent";

        #endregion

        #region Methods

        /// <summary>
        /// Converts the properties of the event into a dictionary of key-value pairs.
        /// </summary>
        /// <returns>
        /// A dictionary containing the event properties as key-value pairs,
        /// where the keys are the parameter names and the values are their corresponding values.
        /// </returns>
        public override Dictionary<string, object> ToDictionary()
        {
            return new Dictionary<string, object>
            {
                { "paramString", ParamString },
                { "paramInt", ParamInt },
                { "paramFloat", ParamFloat },
                { "paramBool", ParamBool }
            };
        }

        #endregion
    }
}
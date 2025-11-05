#if ANALYTICS_ENABLED
using Marmary.Analytics.Events;
using UnityEngine;

namespace Marmary.Analytics
{
    /// <summary>
    /// Represents a class used for handling analytics in the context of Unity applications.
    /// </summary>
    public class TestAnalytics : MonoBehaviour
    {
        #region Fields

        /// <summary>
        /// Represents an instance of an analytics service used for initializing and tracking events.
        /// </summary>
        /// <remarks>
        /// This variable holds a reference to an implementation of the <c>IAnalyticsService</c> interface,
        /// which provides methods for initializing the analytics system and tracking custom analytics events.
        /// </remarks>
        private IAnalyticsService _analytics;

        #endregion

        #region Unity Event Functions

        /// <summary>
        /// Initializes the analytics service and tracks an event with predefined parameters upon starting the Unity MonoBehaviour.
        /// </summary>
        /// <remarks>
        /// This method initializes Unity Services using an instance of the UnityAnalyticsService. Once the analytics service
        /// is initialized, it tracks a custom event of type <see cref="MyEvent"/> with a set of parameters including a boolean,
        /// integer, string, and float values.
        /// </remarks>
        /// <exception cref="System.Exception">
        /// If the initialization of the analytics service fails or encounters an error.
        /// </exception>
        /// <seealso cref="UnityAnalyticsService"/>
        /// <seealso cref="IAnalyticsService"/>
        /// <seealso cref="MyEvent"/>
        private async void Start()
        {
            // Inicializa Unity Services
            _analytics = new UnityAnalyticsService();
            await _analytics.Initialize();
            _analytics.TrackEvent(new MyEvent
            {
                ParamBool = true,
                ParamInt = 1,
                ParamString = "Hola",
                ParamFloat = 1.2f
            });


            Debug.Log("Evento 'myEvent' enviado.");
        }

        #endregion
    }
}
#endif
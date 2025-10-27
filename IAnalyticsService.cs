using System.Threading.Tasks;

namespace Marmary.Analytics
{
    /// <summary>
    /// Represents a service for initializing and tracking analytics events.
    /// </summary>
    /// <remarks>
    /// This interface defines methods that allow initialization of an analytics service
    /// and tracking of analytics events using implementations of the <c>AnalyticsEvent</c>.
    /// Specific implementations of this interface can provide concrete logic for analytics setup
    /// and event handling.
    /// </remarks>
    public interface IAnalyticsService
    {
        #region Methods

        /// <summary>
        /// Initializes the analytics service by setting up necessary configurations
        /// and ensuring that the service is ready to track events. This method must
        /// be called before any analytics events are logged.
        /// </summary>
        /// <returns>A task representing the asynchronous initialization operation.</returns>
        Task Initialize();

        /// <summary>
        /// Tracks a specific analytics event with its associated data.
        /// </summary>
        /// <param name="event">The analytics event to be tracked, encapsulating the event name and relevant data.</param>
        void TrackEvent(AnalyticsEvent @event);

        #endregion
    }
}
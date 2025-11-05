#if ANALYTICS_ENABLED
using System.Threading.Tasks;
using Unity.Services.Analytics;
using Unity.Services.Core;
using UnityEngine;
using UnityEngine.UnityConsent;

namespace Marmary.Analytics
{
    /// <summary>
    ///     The UnityAnalyticsService class provides functionality to integrate and manage analytics
    ///     in a Unity project using Unity's Analytics and Services APIs.
    /// </summary>
    /// <remarks>
    ///     This class implements the IAnalyticsService interface to initialize Unity Services
    ///     and handle analytics tracking events. It manages consent settings automatically
    ///     and only allows event tracking after initialization.
    /// </remarks>
    public class UnityAnalyticsService : IAnalyticsService
    {
        #region Fields

        /// <summary>
        ///     Indicates whether the analytics service has been successfully initialized.
        /// </summary>
        /// <remarks>
        ///     This flag is used to determine if the Unity Analytics Service has been set up properly.
        ///     It prevents redundant initialization attempts and ensures that analytics events
        ///     are only tracked after the service has been initialized.
        /// </remarks>
        private bool _initialized;

        #endregion

        #region IAnalyticsService Members

        /// <summary>
        ///     Initializes the Unity Analytics Service by setting up necessary configurations
        ///     and states such as user consent. This ensures that analytics events can
        ///     be tracked properly across the system.
        /// </summary>
        /// <returns>A task representing the asynchronous initialization operation.</returns>
        public async Task Initialize()
        {
            if (_initialized)
                return;

            await UnityServices.InitializeAsync();

            var consent = EndUserConsent.GetConsentState();
            consent.AnalyticsIntent = ConsentStatus.Granted;
            EndUserConsent.SetConsentState(consent);

            _initialized = true;
            Debug.Log("[Analytics] Unity Analytics inicializado.");
        }

        /// <summary>
        ///     Tracks a custom analytics event.
        /// </summary>
        /// <param name="event">The analytics event to be tracked, containing its name and associated data.</param>
        public void TrackEvent(AnalyticsEvent @event)
        {
            if (!_initialized)
            {
                Debug.LogWarning("[Analytics] Intento de registrar evento antes de inicializar.");
                return;
            }

            var customEvent = new CustomEvent(@event.Name);
            foreach (var kvp in @event.ToDictionary())
                customEvent.Add(kvp.Key, kvp.Value);

            AnalyticsService.Instance.RecordEvent(customEvent);
        }

        #endregion
    }
}
#endif
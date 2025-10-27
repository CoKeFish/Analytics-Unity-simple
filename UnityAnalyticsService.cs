using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Services.Analytics;
using Unity.Services.Core;
using UnityEngine.UnityConsent;
using UnityEngine;

namespace Scrips.Analytics
{
    public class UnityAnalyticsService : IAnalyticsService
    {
        private bool _initialized;

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
    }
}
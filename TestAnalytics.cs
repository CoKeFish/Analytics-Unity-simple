using Scrips.Analytics;
using Unity.Services.Analytics;
using Unity.Services.Core;
using UnityEngine;
using UnityEngine.UnityConsent;
using IAnalyticsService = Scrips.Analytics.IAnalyticsService;

public class TestAnalytics : MonoBehaviour
{
    private IAnalyticsService analytics;

    async void Start()
    {
        // Inicializa Unity Services
        analytics = new UnityAnalyticsService();
        await analytics.Initialize();
        analytics.TrackEvent(new MyEvent
        {
            ParamBool = true,
            ParamInt = 1,
            ParamString = "Hola",
            ParamFloat = 1.2f
        });


        Debug.Log("Evento 'myEvent' enviado.");
    }

    private void Update()
    {

    }
}
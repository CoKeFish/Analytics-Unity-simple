using System.Threading.Tasks;

namespace Scrips.Analytics
{
    public interface IAnalyticsService
    {
        Task Initialize();

        void TrackEvent(AnalyticsEvent @event);
    }
}
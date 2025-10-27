using System.Collections.Generic;

namespace Scrips.Analytics
{
    public abstract class AnalyticsEvent
    {
        public abstract string Name { get; }
        public abstract Dictionary<string, object> ToDictionary();
    }
}
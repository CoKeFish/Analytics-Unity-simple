using System.Collections.Generic;

namespace Scrips.Analytics
{
    public class MyEvent : AnalyticsEvent
    {
        public string ParamString { get; set; }
        public int ParamInt { get; set; }
        public float ParamFloat { get; set; }
        public bool ParamBool { get; set; }

        public override string Name => "myEvent";

        public override Dictionary<string, object> ToDictionary() => new()
        {
            { "paramString", ParamString },
            { "paramInt", ParamInt },
            { "paramFloat", ParamFloat },
            { "paramBool", ParamBool }
        };
    }
}
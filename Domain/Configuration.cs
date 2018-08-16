using System;

namespace Domain
{
    public class Configuration
    {
        // process settings
        public int CheckInterval { get; set; } = 5000;

        // image change detector settings
        public int SizeShrink { get; set; } = 10;
        public int ColorShrink { get;set; } = 32;
        public int Tolerance { get; set; } = 4;
        public int MaxGlitches { get; set; } = 32;

        // image delivery settings
        public string SCPHostName { get; set; }
        public int SCPPort { get; set; } = 443;
        public string SCPUser { get; set; }
        public string SCPPass { get; set; }
        public string SCPDestinationPath { get; set; }
        public uint SCPBuffersize { get; set; } = 1024;
        public TimeSpan SCPTimeout { get; set; } = TimeSpan.FromSeconds(30);

    }
}

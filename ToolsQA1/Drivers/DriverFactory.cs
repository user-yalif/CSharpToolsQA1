using System;
using ToolsQA1.Drivers.Interfaces;
using ToolsQA1.Framework;
using static ToolsQA1.Utils.Logger;

namespace ToolsQA1.Drivers
{
    public class DriverFactory : IDriverFactory
    {
        public override IDriver GetDriver(string browserType)
        {
            switch (browserType)
            {
                case "Chrome":
                    return new DriverChrome();
                default:
                    Log.Error($"{Settings.BrowserType} browser type is not supported.");
                    throw new PlatformNotSupportedException($"{Settings.BrowserType} browser type is not supported.");
            };
        }
    }
}

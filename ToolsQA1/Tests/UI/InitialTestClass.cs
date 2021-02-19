using NUnit.Framework;
using static ToolsQA1.Utils.Logger;

namespace ToolsQA1.Tests.UI
{
    public class InitialTestClass : BaseTest
    {
        [Test]
        public void LogTest()
        {
            Log.Info("Info message.");
            Log.Warn("Warning message.");
            Log.Error("Error message.");
        }
    }
}

using log4net;
using System.Reflection;

namespace ToolsQA1.Utils
{
    public class Logger
    {
        public static ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    }
}

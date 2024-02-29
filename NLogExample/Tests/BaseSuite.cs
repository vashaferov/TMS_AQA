using NLog;
using NLogExample.Core;

namespace NLogExample.Tests;

[SetUpFixture]
public class BaseSuite
{
    private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
    
    [OneTimeSetUp]
    public static void SuiteSetUp()
    {
        Logger.Info("NLog Config...");
        new NLogConfig().Config();
        //new NLogConfig().ColoredConfig();
    }
}
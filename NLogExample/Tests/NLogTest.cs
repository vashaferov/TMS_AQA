using NLog;

namespace NLogExample.Tests;
[TestFixture]
public class NLogTest
{
    protected static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
    
    [Test]
    public void LevelsTest()
    {
        Logger.Log(LogLevel.Info, "Info level log");
        
        Logger.Trace("Trace level");
        Logger.Debug("Debug level");
        Logger.Info("Info level");
        Logger.Warn("Warn level");
        Logger.Error("Error level");
        Logger.Fatal("Fatal level");
    }

    [Test]
    public void ExceptionLogTest()
    {
        try
        {
            throw new AssertionException("Ошибка");
        }
        catch (Exception e)
        {
            Logger.Error(e, "Логируем ошибку");
        }
    }
}
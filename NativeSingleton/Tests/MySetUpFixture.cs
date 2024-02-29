namespace NativeSingleton.Tests;

[SetUpFixture]
public class MySetUpFixture
{
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        BrowserSingleton.GetInstance().CloseDriver();
    }
}
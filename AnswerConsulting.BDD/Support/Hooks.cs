using OpenQA.Selenium.PhantomJS;

using TechTalk.SpecFlow;

namespace AnswerConsulting.BDD.Support
{
    [Binding]
    public sealed class Hooks : Setup
    {
        [BeforeTestRun]
        public static void Start()
        {
            Driver = new PhantomJSDriver();
        }

        [AfterTestRun]
        public static void Stop()
        {
            Driver.Quit();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            
        }
    }
}

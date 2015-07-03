using OpenQA.Selenium.PhantomJS;

namespace AnswerConsulting.BDD.Support
{
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;

    public abstract class Setup
    {
        protected static PhantomJSDriver Driver;
    }
}

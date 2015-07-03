using System.Xml;
using System.Linq;

using AnswerConsulting.BDD.Helpers;
using AnswerConsulting.BDD.Support;

using NUnit.Framework;

using OpenQA.Selenium;

using TechTalk.SpecFlow;

namespace AnswerConsulting.BDD.Features.Steps
{
    [Binding]
    public sealed class DisasterRecoverySteps : Setup
    {
        [Given(@"I am on the (.*) page")]
        public void GivenIAmOnThePage(string page)
        {
            Driver.Navigate().GoToUrl(PageNavigation.GetUrlByString(page));
        }

        [When(@"I look at the footer information")]
        public void WhenILookAtTheFooterInformation()
        {
            var footer = Driver.FindElementByClassName("main-footer");
            Assert.IsTrue(footer.Displayed);
        }

        [Then(@"the social link are displayed")]
        public void ThenTheSocialLinkIsDisplayed()
        {
            var facebook = Driver.FindElementByClassName("social-facebook");
            var twitter = Driver.FindElementByClassName("social-twitter");
            var google = Driver.FindElementByClassName("social-googleplus");
            var linkedin = Driver.FindElementByClassName("social-linkedin");

            Assert.IsTrue(facebook.Displayed);
            Assert.IsTrue(twitter.Displayed);
            Assert.IsTrue(google.Displayed);
            Assert.IsTrue(linkedin.Displayed);
        }

        [Then(@"I can see the (.*)")]
        public void ThenICanSeeThe(string headerText)
        {
            var actualH1Text = Driver.FindElementByClassName("page-title").Text;
            Assert.AreEqual(headerText, actualH1Text);
        }

        [Then(@"the address '(.*)' is displayed")]
        public void ThenTheAddressIsDisplayed(string address)
        {
            var footerSection = Driver.FindElementByTagName("footer");
            var addressInfo = footerSection.FindElements(By.TagName("p")).SingleOrDefault(t => t.Text.Contains(address));
            Assert.IsNotNull(addressInfo, string.Format("{0}, was not found in the footer.", address));
        }

        [Then(@"the company information '(.*)' is dispayed")]
        public void ThenTheCompanyInformationIsDispayed(string companyRegistration)
        {
            var footerSection = Driver.FindElementByTagName("footer");
            var companyInformation =
                footerSection.FindElements(By.TagName("p")).SingleOrDefault(t => t.Text.Contains(companyRegistration));
            Assert.IsNotNull(companyInformation, string.Format("{0}, was not found in the page footer", companyRegistration));
        }

        [Given(@"I navigate to the sitemap")]
        public void GivenINavigateToTheSitemap()
        {
            Driver.Navigate().GoToUrl(PageNavigation.Url(Page.Sitemap));
        }

        [Then(@"the XML markup is valid")]
        public void ThenTheXMLMarkupIsValid()
        {
            var pageSource = Driver.PageSource;
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(pageSource);
        }

        [Then(@"all pages are working")]
        public void ThenAllPagesAreWorking()
        {
            var pageSource = Driver.PageSource;
            var xml = new XmlDocument();
            xml.LoadXml(pageSource);

            foreach (var urlLinks in xml.GetElementsByTagName("loc"))
            {
                Driver.Navigate().GoToUrl(urlLinks.ToString());
            }
        }

    }
}

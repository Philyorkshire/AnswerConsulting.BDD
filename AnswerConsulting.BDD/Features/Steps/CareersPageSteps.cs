using System.Linq;
using AnswerConsulting.BDD.Helpers;
using AnswerConsulting.BDD.Support;

using NUnit.Framework;

using OpenQA.Selenium;

using TechTalk.SpecFlow;

namespace AnswerConsulting.BDD.Features.Steps
{
    [Binding]
    public sealed class CareersPageSteps : Setup
    {
        [Given(@"I am on the careers section")]
        public void GivenIAmOnTheCareersSection()
        {
            Driver.Navigate().GoToUrl(PageNavigation.Url(Page.Careers));
        }

        [Given(@"the heading '(.*)' is displayed")]
        public void GivenTheHeadingIsDisplayed(string headingText)
        {
            var actualHeadingText = Driver.FindElementByClassName("page-title").Text;

            Assert.AreEqual(headingText, actualHeadingText, string.Format("Heading expected to be {0} but was actually {1}.",
                headingText, actualHeadingText));
        }

        [Given(@"the sub-heading '(.*)' is displayed")]
        public void GivenTheSub_HeadingIsDisplayed(string subHeadingText)
        {
            var actualSubHeading = Driver.FindElementsByTagName("h2").Single(h => h.Text == subHeadingText).Text;

            Assert.AreEqual(subHeadingText, actualSubHeading, string.Format("Sub heading expected to be {0} but was actually {1}.",
                subHeadingText, actualSubHeading));
        }

        [When(@"I click on the first vacancy")]
        public void WhenIClickOnTheFirstVacancy()
        {
            var firstVacancyLink =
                Driver.FindElementByXPath("//*[@id='main']/section[3]/div")
                    .FindElement(By.PartialLinkText("Read more..."));

            firstVacancyLink.Click();
        }

        [Then(@"I am taken to the vacancy page")]
        public void ThenIAmTakenToTheVacancyPage()
        {
            var headingThreeElements = Driver.FindElementsByTagName("h3");

            Assert.IsNotNull(headingThreeElements.SingleOrDefault(t => t.Text.Contains("Experience Required")));
            Assert.IsNotNull(headingThreeElements.SingleOrDefault(t => t.Text.Contains("Desirable Skills")));
            Assert.IsNotNull(headingThreeElements.SingleOrDefault(t => t.Text.Contains("Apply Now")));
        }

        [Then(@"'(.*)' is displayed")]
        public void ThenIsDisplayed(string text)
        {
            var pageText = Driver.FindElementsByTagName("p").Single(t => t.Text == text);

            Assert.AreEqual(text, pageText.Text);
            Assert.IsTrue(pageText.Displayed);
        }

        [When(@"I click on the '(.*)' section")]
        public void WhenIClickOnTheSection(string readMore)
        {
            var graduateSection = Driver.FindElementByXPath("//*[@id='main']/section[2]/div");
            graduateSection.FindElement(By.PartialLinkText(readMore)).Click();
        }

        [Then(@"the information relates to the graduate academy")]
        public void ThenTheInformationRelatesToTheGraduateAcademy()
        {
            ScenarioContext.Current.Pending();
        }

    }
}

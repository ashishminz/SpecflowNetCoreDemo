using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SpecflowNetCoreDemo.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SpecflowNetCoreDemo.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        public IWebDriver driver;
        LoginPage lp = null;

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:8888/");
            lp = new LoginPage(driver);
        }

        [Given(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                lp.LoginApplication((string)row[0], (string)row[1]);
            }
           
        }

        [Given(@"I click the login button")]
        public void GivenIClickTheLoginButton()
        {
            lp.loginButton.Click();
        }

        [Then(@"I should be on the homepage of the vtiger website")]
        public void ThenIShouldBeOnTheHomepageOfTheVtigerWebsite()
        {
            Assert.That(lp.HomePageVerify(), Is.True);
        }

        [Then(@"I should be on the loginpage of the vtiger website")]
        public void ThenIShouldBeOnTheLoginpageOfTheVtigerWebsite()
        {
            Assert.That(lp.loginPageVerify(), Is.True);
        }

        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
           driver.Close();
        }


    }
}

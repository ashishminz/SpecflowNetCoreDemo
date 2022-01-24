using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System;

namespace SpecflowNetCoreDemo.PageObjects
{
    internal class LoginPage
    {
       IWebDriver driver;
            public LoginPage(IWebDriver driver)
            {
                this.driver = driver;


            }
            public IWebElement usernameTextField => driver.FindElement(By.Name("user_name"));
            public IWebElement passwordTextField => driver.FindElement(By.Name("user_password"));
            public IWebElement loginButton => driver.FindElement(By.Id("submitButton"));
            public IWebElement invalidError => driver.FindElement(By.XPath("//div[text()='Invalid Login Credentials']"));
            public IWebElement homeButton => driver.FindElement(By.PartialLinkText("Home"));

            public void LoginApplication(string userName, string passWord)
            {
                try
                {
                    usernameTextField.SendKeys(userName.Trim());
                    passwordTextField.SendKeys(passWord.Trim());
                   
                }
                catch (Exception E)
                {
                    Console.WriteLine("Test Fail: did not enter username and password  : {0}", E.Message);
                    throw;
                }
            }

            public void LoginBtnClick()
                {
                loginButton.Click();
            }

        public bool HomePageVerify() => homeButton.Displayed;
                

        }
    }


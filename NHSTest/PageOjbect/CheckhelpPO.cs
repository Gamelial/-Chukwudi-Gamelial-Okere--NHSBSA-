using NHSTest.Utilties;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHSTest.PageOjbect
{
     class CheckhelpPO
    {
        public CheckhelpPO() 
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;



        IWebElement Cookies => driver.FindElement(By.XPath("//button[@id='nhsuk-cookie-banner__link_accept_analytics']"));
        IWebElement Startnow => driver.FindElement(By.XPath("//input[@class='button button-get-started']"));
        IWebElement Scotland => driver.FindElement(By.XPath("(//input[@type='radio'])[2]"));
        IWebElement Next => driver.FindElement(By.XPath("//input[@class='button']"));
        IWebElement HighlandsandIsland => driver.FindElement(By.XPath("//label[@for='radio-yes']"));
        IWebElement Next2 => driver.FindElement(By.XPath("//input[@id='next-button']"));
        IWebElement PracticeinScotland => driver.FindElement(By.XPath("//label[@for='radio-scotland']"));
        IWebElement Next3 => driver.FindElement(By.XPath("//input[@id='next-button']"));
        IWebElement Day => driver.FindElement(By.XPath("//input[@id='dob-day']"));
        IWebElement Month => driver.FindElement(By.XPath("//input[@id='dob-month']"));
        IWebElement Year => driver.FindElement(By.XPath("//input[@id='dob-year']"));
        IWebElement Next4 => driver.FindElement(By.XPath("//input[@id='next-button']"));
        IWebElement Partner => driver.FindElement(By.XPath("//label[@for='radio-no']"));
        IWebElement Next5 => driver.FindElement(By.XPath("//input[@id='next-button']"));
        IWebElement Tax => driver.FindElement(By.XPath("//input[@id='radio-no']"));
        IWebElement Next6 => driver.FindElement(By.XPath("//input[@id='next-button']"));
        IWebElement Pregnant => driver.FindElement(By.XPath("//input[@id='radio-no']"));
        IWebElement Next7 => driver.FindElement(By.XPath("//input[@id='next-button']"));
        IWebElement Injury => driver.FindElement(By.XPath("//input[@id='radio-no']"));
        IWebElement Next8 => driver.FindElement(By.XPath("//input[@id='next-button']"));
        IWebElement Carehome => driver.FindElement(By.XPath("//input[@id='radio-no']"));
        IWebElement Next9 => driver.FindElement(By.XPath("//input[@id='next-button']"));
        IWebElement Morethan => driver.FindElement(By.XPath("//input[@id='radio-no']"));
        IWebElement Next10 => driver.FindElement(By.XPath("//input[@id='next-button']"));
        IWebElement FindOutMore => driver.FindElement(By.XPath("//a[@class='button button-get-started']"));
        IWebElement Continue => driver.FindElement(By.XPath("(//button[@name='continueSavedApplication'])[2]"));
        IWebElement Email => driver.FindElement(By.XPath("//input[@id='saveresume-resumeemail']"));
        IWebElement Continuee => driver.FindElement(By.XPath("//input[@value='Continue']"));
        IWebElement DDays => driver.FindElement(By.XPath("(//input[@class='form-control'])[1]"));
        IWebElement MMonths => driver.FindElement(By.XPath("(//input[@class='form-control'])[2]"));
        IWebElement YYear => driver.FindElement(By.XPath("(//input[@class='form-control'])[3]"));
        IWebElement Continueee => driver.FindElement(By.XPath("//input[@value='Continue']"));
        IWebElement Feedback => driver.FindElement(By.XPath("//a[@id='feedback-link']"));










        // Methond

        public void NavigateToWebSite(string url)
        {
            driver.Navigate().GoToUrl(url); 
        }

        public void ClickOnCookies()
        {
            Cookies.Click();
        }

        public void ClickOnStartnow()
        {
            Startnow.Click();
        }

        public void ClickOnScotland()
        {
            Scotland.Click();
        }

        public void ClickOnNext()
        {
            Next.Click();
        }

        public void ClickOnHighlandsandIsland()
        {
            HighlandsandIsland.Click();
        }

        public void ClickOnNext2()
        {
            Next2.Click();
        }

        public void ClickOnPracticeinScotland()
        {
            PracticeinScotland.Click();
        }

        public void ClickOnNext3()
        {
            Next3.Click();
        }

        public void EnterDayy(string day)
        {
            Day.SendKeys(day);
        }

        public void EnterMonth(string month)
        {
            Month.SendKeys(month);
        }

        public void EnterYear(string year)
        {
            Year.SendKeys(year);
        }

        public void ClickOnNext4()
        {
            Next4.Click();
        }


        public void ClickOnPartner()
        {
            Partner.Click();
        }

        public void ClickOnNext5()
        {
            Next5.Click();
        }

        public void ClickOnTax()
        {
            Tax.Click();
        }

        public void ClickOnNext6()
        {
            Next6.Click();
        }

        public void ClickOnPregnant()
        {
            Pregnant.Click();
        }

        public void ClickOnNext7()
        {
            Next7.Click();
        }
        public void ClickOnInjury()
        {
            Injury.Click();
        }

        public void ClickOnNext8()
        {
            Next8.Click();
        }

        public void ClickOnCarehome()
        {
            Carehome.Click();
        }

        public void ClickOnNext9()
        {
            Next9.Click();
        }

        public void ClickOnMorethan()
        {
            Morethan.Click();
        }
        public void ClickOnNext10()
        {
            Next10.Click();
        }

        public void ClickOnFindOutMore()
        {
            FindOutMore.Click();
        }

        public void ClickOnContinue()
        {
            Continue.Click();
        }

        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void ClickOnContinuee()
        {
            Continuee.Click();
        }

        public void EnterDDays(string ddays)
        {
            DDays.SendKeys(ddays);
        }

        public void EnterMMonths(string mmonths)
        {
            MMonths.SendKeys(mmonths);
        }

        public void EnterYYear(string yyears)
        {
            YYear.SendKeys(yyears);
        }

        public void ClickOnContinueee()
        {
            Continueee.Click();
        }

        public bool IsFeedback()
        {
            return Feedback.Displayed;
        }

       



    }
}

using NHSTest.PageOjbect;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace NHSTest.StepDefinitions
{
    [Binding]
    public class CheckHelpStepDefinitions
    {

        CheckhelpPO checkhelpPO;

        public CheckHelpStepDefinitions() 
        {
            checkhelpPO = new CheckhelpPO();
        }

        [Given(@"I navigate to the website\t\t\t\t\t\t""([^""]*)""")]
        public void GivenINavigateToTheWebsite(string url)
        {
            checkhelpPO.NavigateToWebSite(url);
        }

        [Given(@"I Click on Cookies")]
        public void GivenIClickOnCookies()
        {
            checkhelpPO.ClickOnCookies();
        }


        [Given(@"I Click on Start now")]
        public void GivenIClickOnStartNow()
        {
            checkhelpPO.ClickOnStartnow();
        }

        [Given(@"I Click on Country I Live as Scotland")]
        public void GivenIClickOnCountryILiveAsScotland()
        {
            checkhelpPO.ClickOnScotland();
        }

        [Given(@"I Click Next")]
        public void GivenIClickNext()
        {
            checkhelpPO.ClickOnNext();
        }

        [Given(@"I Click do I Live Highlands and Island Yes")]
        public void GivenIClickDoILiveHighlandsAndIslandYes()
        {
            checkhelpPO.ClickOnHighlandsandIsland();
        }

        [Given(@"I Click is your Dental Practice in Scotland")]
        public void GivenIClickIsYourDentalPracticeInScotland()
        {
            checkhelpPO.ClickOnPracticeinScotland();
        }
        [Given(@"I Enter Day\t\t\t\t\t\t\t\t\t\t""([^""]*)""")]


        public void GivenIEnterDayy(string dayy)
        {
            checkhelpPO.EnterDayy(dayy);
        }

        [Given(@"I Enter Month\t\t\t\t\t\t\t\t\t""([^""]*)""")]
        public void GivenIEnterMonth(string month)
        {
            checkhelpPO.EnterMonth(month);
        }

        [Given(@"I Enter Year\t\t\t\t\t\t\t\t\t""([^""]*)""")]
        public void GivenIEnterYear(string year)
        {
            checkhelpPO.EnterYear(year);
        }


        [Given(@"I Click Do I Live with a partner No")]
        public void GivenIClickDoILiveWithAPartnerNo()
        {
            checkhelpPO.ClickOnPartner();
        }

        [Given(@"I Click Do You Claim Benefit or tax No")]
        public void GivenIClickDoYouClaimBenefitOrTaxNo()
        {
            checkhelpPO.ClickOnTax();
        }

        [Given(@"Click on Are you pregnant No")]
        public void GivenClickOnAreYouPregnantNo()
        {
            checkhelpPO.ClickOnPregnant();
        }

        [Given(@"Click Do you have any injury No")]
        public void GivenClickDoYouHaveAnyInjuryNo()
        {
            checkhelpPO.ClickOnInjury();
        }

        [Given(@"I Click Do you live permantly in care home No")]
        public void GivenIClickDoYouLivePermantlyInCareHomeNo()
        {
            checkhelpPO.ClickOnCarehome();
        }

        [Given(@"I Click Do you have more than No")]
        public void GivenIClickDoYouHaveMoreThanNo()
        {
            checkhelpPO.ClickOnMorethan();
        }

        [Given(@"I Click Find out more")]
        public void GivenIClickFindOutMore()
        {
            checkhelpPO.ClickOnFindOutMore();   
        }

        [Given(@"I Click on Continue")]
        public void GivenIClickOnContinue()
        {
            checkhelpPO.ClickOnContinue();
        }

        [Given(@"I Enter Email\t\t\t\t\t\t\t\t\t\t\t\t""([^""]*)""")]
        public void GivenIEnterEmail(string email)
        {
            checkhelpPO.EnterEmail(email);
        }
        [Given(@"I Click on Continuee")]
        public void GivenIClickOnContinuee()
        {
            checkhelpPO.ClickOnContinuee();
        }

        [Given(@"I Enter the DDays\t\t\t\t\t\t\t\t\t\t\t\t\t""([^""]*)""")]
        public void GivenIEnterTheDDays(string ddays)
        {
            checkhelpPO.EnterDDays(ddays);
        }

        [Given(@"I Enter the MMonths\t\t\t\t\t\t\t\t\t\t\t        ""([^""]*)""")]
        public void GivenIEnterTheMMonths(string mmonths)
        {
            checkhelpPO.EnterMMonths(mmonths);
        }

        [Given(@"I Enter the YYear\t\t\t\t\t\t\t\t\t\t\t\t    ""([^""]*)""")]
        public void GivenIEnterTheYYear(string yyear)
        {
            checkhelpPO.EnterYYear(yyear);
        }


        [When(@"I Click on continueee")]
        public void WhenIClickOnContinueee()
        {
            checkhelpPO.ClickOnContinueee();
        }


        [When(@"And I Click Next")]
        public void WhenAndIClickNext()
        {
            checkhelpPO.ClickOnNext10();
        }

        [Then(@"This displace You Get NHS costs")]
        public void ThenThisDisplaceYouGetNHSCosts()
        {
            Assert.That(checkhelpPO.IsFeedback);
        }

    }
}

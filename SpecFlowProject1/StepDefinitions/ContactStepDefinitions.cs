using System;
using TechTalk.SpecFlow;
using SpecFlowProject1.Hooks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ContactStepDefinitions
    {
        [When(@"I click on My Info")]
        public void WhenIClickOnMyInfo()
        {
            Automation.driver.FindElement(By.XPath("//span[text()='My Info']")).Click();

        }
       

        [When(@"I click on emergency contact section")]
        public void WhenIClickOnEmergencyContactSection()
        {
            Automation.driver.FindElement(By.XPath("//a[text()='Emergency Contacts']")).Click();

        }

        [When(@"I click on add Assigned Emergency Contacts")]
        public void WhenIClickOnAddAssignedEmergencyContacts()
        {
            Automation.driver.FindElement(By.XPath("//h6[contains(@class,'orange')]/following::button")).Click();

        }


        [When(@"I fill emergency contact details")]
        public void WhenIFillEmergencyContactDetails(Table table)
        {
            string name=table.Rows[0]["name"];
            string relationship = table.Rows[0]["relationship"];
            string hometelephone = table.Rows[0]["home_telephone"];
            string worktelephone = table.Rows[0]["work_telephone"];
            string mobile = table.Rows[0]["mobile"];

            Automation.driver.FindElement(By.XPath("//label[contains(text(),'Name')]/following::input")).SendKeys(name);
            Automation.driver.FindElement(By.XPath("//label[contains(text(),'Relationship')]/following::input")).SendKeys(relationship);
            Automation.driver.FindElement(By.XPath("//label[contains(text(),'Home Tele')]/following::input")).SendKeys(hometelephone);
            Automation.driver.FindElement(By.XPath("//label[contains(text(),'Mobile')]/following::input")).SendKeys(worktelephone);
            Automation.driver.FindElement(By.XPath("//label[contains(text(),'Work')]/following::input")).SendKeys(mobile);


        }

        [When(@"I click on save emergency contact")]
        public void WhenIClickOnSaveEmergencyContact()
        {
            Automation.driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [Then(@"I should be navigated to view emergency contact section")]
        public void ThenIShouldBeNavigatedToViewEmergencyContactSection()
        {
           
        }
    }
}

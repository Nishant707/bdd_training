using System;
using TechTalk.SpecFlow;
using SpecFlowProject1.Hooks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class EmployeeStepDefinitions
    {
        string fName;
        [When(@"I click on PIM")]
        public void WhenIClickOnPIM()
        {
            Automation.driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
            
        }

        [When(@"I click on Add Employee")]
        public void WhenIClickOnAddEmployee()
        {
            Automation.driver.FindElement(By.XPath("//a[text()='Add Employee']")).Click();
        }

        [When(@"I fill the add employee section")]
        public void WhenIFillTheAddEmployeeSection(Table table)
        {
            fName = table.Rows[0]["firstname"];
            string mName = table.Rows[0]["middlename"];
            string lName = table.Rows[0]["lastname"];
            string empid = table.Rows[0]["employee_id"];
            string toggleLoginDetail = table.Rows[0]["toggle_login_detail"];
            string userName = table.Rows[0]["username"];
            string password = table.Rows[0]["password"];
            string confirmpassword = table.Rows[0]["confirm_password"];
            string status = table.Rows[0]["status"];

            Automation.driver.FindElement(By.Name("firstName")).SendKeys(fName);
            Automation.driver.FindElement(By.Name("middleName")).SendKeys(mName);
            Automation.driver.FindElement(By.Name("lastName")).SendKeys(lName);
          /*  Automation.driver.FindElement(By.Name("Employee_id")).SendKeys(empid);
            Automation.driver.FindElement(By.Name("toggle_login_detail")).SendKeys(toggleLoginDetail);
            Automation.driver.FindElement(By.Name("username")).SendKeys(userName);
            Automation.driver.FindElement(By.Name("password")).SendKeys(password);
            Automation.driver.FindElement(By.Name("confirm_password")).SendKeys(confirmpassword);
            Automation.driver.FindElement(By.Name("status")).SendKeys(status);*/

            if (toggleLoginDetail.Equals("on"))
            {
                Automation.driver.FindElement(By.XPath("//span[contains(@class,'oxd-switch-input')]")).Click();
            }
            Automation.driver.FindElement(By.XPath("//label[contains(text(),'Username')]/following::input")).SendKeys(userName);
            Automation.driver.FindElement(By.XPath("//label[contains(text(),'Password')]/following::input")).SendKeys(password);
            Automation.driver.FindElement(By.XPath("//label[contains(text(),'Confirm Password')]/following::input")).SendKeys(confirmpassword);
            if (status.ToLower().Equals("disabled"))
            {
                Automation.driver.FindElement(By.XPath("//label[text()='Disabled']")).Click();

            }
            else
            {
                Automation.driver.FindElement(By.XPath("//label[text()='Enabled']")).Click();


            }





        }

        [When(@"I click on save employee")]
        public void WhenIClickOnSaveEmployee()
        {
            Automation.driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [When(@"I should navigate to add personal detail section with added employee")]
        public void WhenIShouldNavigateToAddPersonalDetailSectionWithAddedEmployee()
        {
            string actualFirstName=Automation.driver.FindElement(By.Name("firstName")).GetAttribute("value");
            Assert.Equal(fName, actualFirstName);
           
        }
    }
}

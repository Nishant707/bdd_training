using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.Hooks
{
    [Binding]
    public class Automation
    {
        public static IWebDriver driver;
    }
}

using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Pages
{
    public class AdminPanelPage : BasePage
    {
        public AdminPanelPage(DriverBuilder driver) : base(driver) { }

        public IButton HamburgerMenu => new WebElement(Driver, "//button[@aria-label='open drawer']", Selector.Xpath);

        //USERS PAGE
        public IButton ID => new WebElement(Driver, "//span[normalize-space()='ID']", Selector.Xpath);
        public IButton FirstName => new WebElement(Driver, "//span[normalize-space()='Firstname']", Selector.Xpath);
        public IButton LastName => new WebElement(Driver, "//span[normalize-space()='Lastname']", Selector.Xpath);
        public IButton Email => new WebElement(Driver, "//span[normalize-space()='Email']", Selector.Xpath);
        public IButton Role => new WebElement(Driver, "//span[normalize-space()='Role']", Selector.Xpath);
        public IButton Credits => new WebElement(Driver, "//span[normalize-space()='Credits']", Selector.Xpath);
        public IButton Edit => new WebElement(Driver, "//span[normalize-space()='Edit']", Selector.Xpath);
        public IButton Remove => new WebElement(Driver, "//span[normalize-space()='Remove']", Selector.Xpath);


        //BUGS PAGE
        public IButton AllBugsOn => new WebElement(Driver, "//button[normalize-space()='On']", Selector.Xpath);
        public IButton AllBugsOff => new WebElement(Driver, "//button[normalize-space()='Off']", Selector.Xpath);









    }
}

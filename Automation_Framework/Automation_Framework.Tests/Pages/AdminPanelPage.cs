using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;
using Automation_Framework.Extensions;
using System.Collections.Generic;

namespace Automation_Framework.Tests.Pages
{
    public class AdminPanelPage : BasePage
    {
        public AdminPanelPage(DriverBuilder driver) : base(driver) { }

        //MENU ITEMS
        public IButton HamburgerMenu => new WebElement(Driver, "//button[@aria-label='open drawer']", Selector.Xpath);
        public IButton BugsMenu => new WebElement(Driver, "//a[@href='#/admin/bugs']//div[@role='button']", Selector.Xpath);
        public IButton LogsMenu => new WebElement(Driver, "//a[@href='#/admin/logs']//div[@role='button']", Selector.Xpath);
        public IButton UsersMenu => new WebElement(Driver, "//a[@href='#/admin/users']//div[@role='button']", Selector.Xpath);

        //MENU ITEMS - Methods
        public void ClickHamburgerMenu() => HamburgerMenu.ClickOnElement();
        public void ClickBugsMenu() => BugsMenu.ClickOnElement();
        public void ClickLogsMenu() => LogsMenu.ClickOnElement();
        public void ClickUsersMenu() => UsersMenu.ClickOnElement();

        //USERS PAGE - WebElements
        public IButton TableHeadUsersID => new WebElement(Driver, "//span[normalize-space()='ID']", Selector.Xpath);
        public IButton TableHeadUsersFirstName => new WebElement(Driver, "//span[normalize-space()='Firstname']", Selector.Xpath);
        public IButton TableHeadUsersLastName => new WebElement(Driver, "//span[normalize-space()='Lastname']", Selector.Xpath);
        public IButton TableHeadUsersEmail => new WebElement(Driver, "//span[normalize-space()='Email']", Selector.Xpath);
        public IButton TableHeadUsersRole => new WebElement(Driver, "//span[normalize-space()='Role']", Selector.Xpath);
        public IButton TableHeadUsersCredits => new WebElement(Driver, "//span[normalize-space()='Credits']", Selector.Xpath);
        public IButton TableHeadUsersEdit => new WebElement(Driver, "//span[normalize-space()='Edit']", Selector.Xpath);
        public IButton TableHeadUsersRemove => new WebElement(Driver, "//span[normalize-space()='Remove']", Selector.Xpath);
        public IButton TableHeadUserFullUsersTable => new WebElement(Driver, "//div[@class='MuiTableContainer-root']", Selector.Xpath);
        public IButton TableHeadUsersTableHead => new WebElement(Driver, "//thead[@class='MuiTableHead-root']", Selector.Xpath);
        public IButton TableHeadUsersTableBody => new WebElement(Driver, "//tbody", Selector.Xpath);


        // USERS PAGE - Methods
        public void RemoveButtonUserByEmail(string email)
        {                                                           // //tr[contains(.,'brent.dar@ap.be')]/child::td[last()]
                                                                    //tr[contains(.,'Brent')]/td[last()]
                                                                    //tr[contains(.,'brent.dar@ap.be')]/td[7]
            IButton removeByEmail = new WebElement(Driver, $"//tr[contains(.,'{email.ToLower()}')]/child::td[last()]", Selector.Xpath);
            removeByEmail.ClickOnElement();
            
        }

        /*public bool CheckIfUserAvailableInList(string email, WebElement element)
        {
            //List<IButton> UserEmails = new List<IButton>(Driver, "(//th[@scope='col'][normalize-space()='First'])[1]//td//tr", Selector.Xpath);
            IList<WebElement> UserEmails = Extensions.WebDriver.ElementFinder.FindElementAboveZero(Driver, (By.XPath(".//th[@scope='col'][normalize-space()='First'])[1]//td//tr")));
            bool UserExist = false;
            foreach (WebElement UserEmail in UserEmails)
            {
                string value = UserEmail.GetInnerHTML();
                if (value.Contains($"{email}"))
                {
                    UserExist = true;
                    break;
                }
            }
            return UserExist;
        }*/
     

        //BUGS PAGE - WebElements
        public IButton AllBugsOn => new WebElement(Driver, "//button[normalize-space()='On']", Selector.Xpath);
        public IButton AllBugsOff => new WebElement(Driver, "//button[normalize-space()='Off']", Selector.Xpath);

        public IButton TableHeadBugsName => new WebElement(Driver, "//span[normalize-space()='Name']", Selector.Xpath);
        public IButton TableHeadBugsDescription => new WebElement(Driver, "//span[normalize-space()='Description']", Selector.Xpath);
        public IButton TableHeadBugsInfo => new WebElement(Driver, "//span[normalize-space()='Info']", Selector.Xpath);
        public IButton TableHeadBugsFunctionality => new WebElement(Driver, "//span[normalize-space()='Functionality']", Selector.Xpath);
        public IButton TableHeadBugsComponent => new WebElement(Driver, "//span[normalize-space()='Component']", Selector.Xpath);
        public IButton TableHeadBugsDifficulty => new WebElement(Driver, "//span[@class='MuiButtonBase-root MuiTableSortLabel-root MuiTableSortLabel-active']", Selector.Xpath);
        public IButton TableHeadBugsToggle => new WebElement(Driver, "//span[normalize-space()='Toggle']", Selector.Xpath);

        
        //BUGS PAGE - Methods
        public void ToggleAllBugsOff() => AllBugsOff.ClickOnElement();

        //LOGS PAGE - WebElements
        public IButton TableHeadLogsType => new WebElement(Driver, "//div[contains(text(),'Type')]", Selector.Xpath);
        public IButton TableHeadLogsMethod => new WebElement(Driver, "//div[contains(text(),'Method')]", Selector.Xpath);
        public IButton TableHeadLogsResponse => new WebElement(Driver, "//div[contains(text(),'Response')]", Selector.Xpath);
        public IButton TableHeadLogsMessage => new WebElement(Driver, "//div[contains(text(),'Message')]", Selector.Xpath);
        public IButton TableHeadLogsPath => new WebElement(Driver, "//div[contains(text(),'Path')]", Selector.Xpath);
        public IButton TableHeadLogsDate => new WebElement(Driver, "//div[contains(text(),'Date')]", Selector.Xpath);
    }

}

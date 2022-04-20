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

        //MENU ITEMS - Functionality
        public void ClickHamburgerMenu() => HamburgerMenu.ClickOnElement();
        public void ClickBugsMenu() => BugsMenu.ClickOnElement();
        public void ClickLogsMenu() => LogsMenu.ClickOnElement();
        public void ClickUsersMenu() => UsersMenu.ClickOnElement();

        //USERS PAGE - WebElements
        public ITable TableHeadUsersID => new WebElement(Driver, "//span[normalize-space()='ID']", Selector.Xpath);
        public ITable TableHeadUsersFirstName => new WebElement(Driver, "//span[normalize-space()='Firstname']", Selector.Xpath);
        public ITable TableHeadUsersLastName => new WebElement(Driver, "//span[normalize-space()='Lastname']", Selector.Xpath);
        public ITable TableHeadUsersEmail => new WebElement(Driver, "//span[normalize-space()='Email']", Selector.Xpath);
        public ITable TableHeadUsersRole => new WebElement(Driver, "//span[normalize-space()='Role']", Selector.Xpath);
        public ITable TableHeadUsersCredits => new WebElement(Driver, "//span[normalize-space()='Credits']", Selector.Xpath);
        public ITable TableHeadUsersEdit => new WebElement(Driver, "//span[normalize-space()='Edit']", Selector.Xpath);
        public ITable TableHeadUsersRemove => new WebElement(Driver, "//span[normalize-space()='Remove']", Selector.Xpath);
        public ITable TableHeadUserFullUsersTable => new WebElement(Driver, "//div[@class='MuiTableContainer-root']", Selector.Xpath);
        public ITable TableHeadUsersTableHead => new WebElement(Driver, "//thead[@class='MuiTableHead-root']", Selector.Xpath);
        public ITable TableHeadUsersTableBody => new WebElement(Driver, "//tbody", Selector.Xpath);

        public ITable EditUserModal => new WebElement(Driver, "//form[@class='css-i8qemz']", Selector.Xpath);
        public IInputField EditCreditsFormField => new WebElement(Driver, "//input[@class='css-yp9swi']", Selector.Xpath);

        public IButton SaveButton => new WebElement(Driver, "//button[normalize-space()='save']", Selector.Xpath);


        // USERS PAGE - Functionality
        public void RemoveUserByEmail(string email)
        {                                                           // //tr[contains(.,'brent.dar@ap.be')]/child::td[last()]
                                                                    //tr[contains(.,'Brent')]/td[last()]
                                                                    //tr[contains(.,'brent.dar@ap.be')]/td[7]
            IButton removeByEmail = new WebElement(Driver, $"//tr[contains(.,'{email.ToLower()}')]/child::td[last()]", Selector.Xpath);
            removeByEmail.ClickOnElement();

        }

        public void EditUserByEmaill(string email)
        {                                                           // //tr[contains(.,'brent.dar@ap.be')]/child::td[last()]
                                                                    //tr[contains(.,'Brent')]/td[last()]
                                                                    //tr[contains(.,'brent.dar@ap.be')]/td[7]
            IButton editByEmail = new WebElement(Driver, $"//tr[contains(.,'{email.ToLower()}')]/child::td[6]", Selector.Xpath);
            editByEmail.ClickOnElement();

        }

        public void EditCredits(string credits)
        {
            EditCreditsFormField.ClearInput();
            EditCreditsFormField.SendKeys(credits);
        }

        public void ClickSave() => SaveButton.ClickOnElement();



        //BUGS PAGE - WebElements
        public IButton AllBugsOn => new WebElement(Driver, "//button[normalize-space()='On']", Selector.Xpath);
        public IButton AllBugsOff => new WebElement(Driver, "//button[normalize-space()='Off']", Selector.Xpath);

        public ITable TableHeadBugsName => new WebElement(Driver, "//span[normalize-space()='Name']", Selector.Xpath);
        public ITable TableHeadBugsDescription => new WebElement(Driver, "//span[normalize-space()='Description']", Selector.Xpath);
        public ITable TableHeadBugsInfo => new WebElement(Driver, "//span[normalize-space()='Info']", Selector.Xpath);
        public ITable TableHeadBugsFunctionality => new WebElement(Driver, "//span[normalize-space()='Functionality']", Selector.Xpath);
        public ITable TableHeadBugsComponent => new WebElement(Driver, "//span[normalize-space()='Component']", Selector.Xpath);
        public ITable TableHeadBugsDifficulty => new WebElement(Driver, "//span[@class='MuiButtonBase-root MuiTableSortLabel-root MuiTableSortLabel-active']", Selector.Xpath);
        public ITable TableHeadBugsToggle => new WebElement(Driver, "//span[normalize-space()='Toggle']", Selector.Xpath);


        //BUGS PAGE - Functionality
        public void ToggleAllBugsOff() => AllBugsOff.ClickOnElement();

        //LOGS PAGE - WebElements
        public ITable TableHeadLogsType => new WebElement(Driver, "//div[contains(text(),'Type')]", Selector.Xpath);
        public ITable TableHeadLogsMethod => new WebElement(Driver, "//div[contains(text(),'Method')]", Selector.Xpath);
        public ITable TableHeadLogsResponse => new WebElement(Driver, "//div[contains(text(),'Response')]", Selector.Xpath);
        public ITable TableHeadLogsMessage => new WebElement(Driver, "//div[contains(text(),'Message')]", Selector.Xpath);
        public ITable TableHeadLogsPath => new WebElement(Driver, "//div[contains(text(),'Path')]", Selector.Xpath);
        public ITable TableHeadLogsDate => new WebElement(Driver, "//div[contains(text(),'Date')]", Selector.Xpath);
    }

}
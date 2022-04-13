using Automation_Framework.Base;
using Automation_Framework.Builders;
using Automation_Framework.Enums;
using Automation_Framework.WebElementModels;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Automation_Framework.Tests.Pages
{
    public class MyMoviesPage : BasePage
    {

        public MyMoviesPage(DriverBuilder driver) : base(driver) { }

        public IButton AllMyMovies => new WebElement(Driver, "css-12m1kat", Selector.ClassName);
        public IButton svg => new WebElement(Driver, "css-1prxee7", Selector.ClassName);

        public IButton MovieTitle => new WebElement(Driver, "//p[@class='css-49l3oe']", Selector.Xpath);
        public IButton MovieAvailableDate => new WebElement(Driver, "//p[@class='css-1l8ljr1']", Selector.Xpath);
        public IButton MovieHoverPoster => new WebElement(Driver, "//img[@class='testing css-8cfhcr']", Selector.Xpath);
        public IButton MovieHoverTitle => new WebElement(Driver, "//p[@class='css-49l3oe']", Selector.Xpath);
        public IButton MovieHoverDescription => new WebElement(Driver, "//p[@class='css-1sivm4u']", Selector.Xpath);
        public IButton MovieHoverActorImage => new WebElement(Driver, "//img[@class='css-8ut8n4']", Selector.Xpath);
        public IButton MovieBox => new WebElement(Driver, "//body/div[@id='root']/div[@class='App']/div/div/div[@class='css-1sxv7u5']/div[@class='css-f97be3']/div[3]", Selector.Xpath);
        public IButton RentWarning => new WebElement(Driver, "//body/div[@id='root']/div[@class='App']/div/div/div[@class='css-1sxv7u5']/div[@class='css-f97be3']/div[3]/p[1]//*[name()='svg']", Selector.Xpath);
        //public IButton MovieHoverRealName => new WebElement(Driver, "//p[@class='css-1sivm4u']", Selector.Xpath);
        //public IButton MovieHoverActorName => new WebElement(Driver, "//p[@class='css-1sivm4u']", Selector.Xpath);



        public IButton WatchNowButton => new WebElement(Driver, "//button[normalize-space()='Watch now']", Selector.Xpath);
        public IButton CloseModalButton => new WebElement(Driver, "//div[@class='css-ce9ngx']//button[@id='CloseModal']", Selector.Xpath);

        public IList<IWebElement> getElements()
        {

            return AllMyMovies.getElements();

        }


        public string GetInnerText_MovieTitle()
        {
            return MovieTitle.Text;
        }
        public string GetInnerText_MovieAvailableDate()
        {
            return MovieAvailableDate.Text;
        }

        public bool AvailabilityOfRentedMovie()
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            string availability = "";
            bool isAvailable = false;
            availability = MovieAvailableDate.Text;
            string date = availability.Substring(17);
            DateTime myDate = DateTime.ParseExact(date, "d", culture);
            DateTime today = DateTime.Today;
            //TimeSpan diff = today - myDate;
            if(myDate >= today)
            {
                isAvailable = true;
            }
            else
            {
                isAvailable = false;
            }
            return isAvailable;
        }

        public IWebElement MovieByTitle(string title)
        {
            return MovieByTitle(title);
        }

        //Functions

        public void ClickWatchNow() => WatchNowButton.ClickOnElement();
        public void ClickCloseModal() => CloseModalButton.ClickOnElement();

    }
}
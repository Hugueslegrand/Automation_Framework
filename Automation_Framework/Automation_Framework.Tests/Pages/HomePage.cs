using Automation_Framework.Base;
using Automation_Framework.Extensions.WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Tests.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        //id: Comedy Movies and id: 531219 => Dynamic
        public IWebElement MovieBannerButton => Driver.FindElement(By.XPath("//div[@id='Comedy Movies']//img[@id='531219']"));

        public IWebElement HorizontalScrollBar => Driver.FindElement(By.XPath("//div[@id='Comedy Movies']//div[@class='css-nlgfro']"));
        public IWebElement BrightestOfficalSite => Driver.FindElement(By.XPath("//a[@class='css-mi3e9x']"));
        public IWebElement BrightestFaceBookSocials => Driver.FindElement(By.XPath("//a[@href='https://www.facebook.com/BrightestNV']"));
        public IWebElement BrightestTwitterSocials => Driver.FindElement(By.XPath("//a[@href='https://twitter.com/brightestnv']"));
        public IWebElement BrightestInstagramSocials => Driver.FindElement(By.XPath("//a[@href='https://www.instagram.com/brightestsoftwarequality/']"));
        public IWebElement BrightestLinkedInSocials => Driver.FindElement(By.XPath("//a[@href='https://www.linkedin.com/company/brightest-nv/']"));


        public IWebElement RentThisMovieButton => Driver.FindElement(By.XPath("//button[@id='RentMovieButton']"));
        public IWebElement MoreInfoButton => Driver.FindElement(By.XPath("//a[@class='css-14nkc1e']"));
        public IWebElement CloseModalButton => Driver.FindElement(By.XPath("//div[@class='css-ce9ngx']//button[@id='CloseModal']"));

        public void ClickMovieBanner() => Driver.ClickOnElement(MovieBannerButton);
        public void ClickBrightestOfficalSite() => Driver.ClickOnElement(BrightestOfficalSite);
        public void ClickBrightestFaceBookSocials() => Driver.ClickOnElement(BrightestFaceBookSocials);
        public void ClickBrightestTwitterSocials() => Driver.ClickOnElement(BrightestTwitterSocials);
        public void ClickBrightestInstagramSocials() => Driver.ClickOnElement(BrightestInstagramSocials);
        public void ClickBrightestLinkedInSocials() => Driver.ClickOnElement(BrightestLinkedInSocials);
        public void ClickRentThisMovie() => Driver.ClickOnElement(RentThisMovieButton);
        public void ClickMoreInfo() => Driver.ClickOnElement(MoreInfoButton);
        public void ClickCloseModal() => Driver.ClickOnElement(CloseModalButton);
    }
}

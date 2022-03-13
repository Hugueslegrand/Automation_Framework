using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Support.UI;



namespace Automation_Framework.Extensions.WebDriver
{
    public static class Populator
    {
        public static List<string> TextReaderFromRow(this IList<IWebElement> elementList)
        {
            List<string> allRowsText = elementList.Select(x => x.Text).ToList();
            return allRowsText;
        }
        
        public static List<string> GetAllRowValuesForColumn(this IList<IWebElement> elementList, int columnIndex)
        {
            List<string> allRowsText = elementList
                                       .Select(x => x.FindElements(By.CssSelector(""))
                                       .ElementAt(columnIndex).Text).ToList();
            return allRowsText;
        }
        

        public static List<string> GetValuesFromDropDown(this IList<IWebElement> elementList)

        {
            List<string> dropdownValues = elementList.Select(x => x.Text).ToList();

            return dropdownValues;

        }
        

        public static void SelectByValueFromSelectTagDropDown(this IWebElement element, string ItemValue)
        {
            SelectElement SelectTagddl = new SelectElement(element);

            SelectTagddl.SelectByText(ItemValue);
            
        }
        
        public static List<string> GetAllOptionsFromSelectTagDropDown(this IWebElement element)
        {
            SelectElement SelectTagddl = new SelectElement(element);

            return SelectTagddl.Options.Select(x => x.Text).ToList();
        }
    }
}

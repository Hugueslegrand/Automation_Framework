using Automation_Framework.Enums;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Framework.Extensions.MobileDriver
{
   
    /// <summary>
    /// A Swipe extension class for mobile
    /// </summary>
    public static class SwipeExtension
    {
        /// <summary>
        /// Method for performing swipe touch actions on screen
        /// </summary>
        /// <param name="driver">Containts the mobile android driver used to run the test in</param>
        /// <param name="startX">The x coordinates on the screen where the touch begins</param>
        /// <param name="startY">The y coordinates on the screen where the touch begins</param>
        /// <param name="endX">The x coordinates on the screen where the touch ends</param>
        /// <param name="endX">The y coordinates on the screen where the touch ends</param>
        /// <param name="duration">The time in milliseconds in which the swipe should be performed</param>
        public static void Swipe(this AppiumDriver<AndroidElement> driver, int startX, int startY, int endX, int endY, int duration)
        {
            ITouchAction touchAction = new TouchAction(driver)
            .Press(startX, startY)
            .Wait(duration)
            .MoveTo(endX, endY)
            .Release();

            touchAction.Perform();
        }

        /*public static void Swipe(this AppiumDriver<AndroidElement> driver, Direction dir)
        {
            int windowWidth = driver.Manage().Window.Size.Width;
            int windowHeight = driver.Manage().Window.Size.Height;
            int startX, endX, startY, endY;
           

            switch (dir)
            {
                case Direction.DOWN: // center of footer
                    startX = endX = windowWidth / 2;
                    startY = (int)(windowHeight * 0.8);
                    endY = (int)(windowHeight * 0.2);
                    break;
                case Direction.UP: // center of header
                    startX = endX = windowWidth / 2;
                    startY = (int)(windowHeight * 0.2);
                    endY = (int)(windowHeight * 0.8);
                    break;
                case Direction.LEFT: // center of left side
                    startY = endY = windowHeight / 2;
                    startX = (int)(windowHeight * 0.8);
                    endX = (int)(windowHeight * 0.2);
                    break;
                case Direction.RIGHT: // center of right side
                    startY = endY = windowHeight / 2;
                    startX = (int)(windowHeight * 0.2);
                    endX = (int)(windowHeight * 0.8);
                    break;
                default:
                    throw new Exception("swipeScreen(): dir: '" + dir + "' NOT supported");
            }

            try
            {
                new TouchAction(driver)
                            .Press(startX, startY)
                            .Wait(300)
                            .MoveTo(endX, endY)
                            .Release()
                            .Perform();
            }
            catch (Exception e)
            {
                
            }
            
        }*/
    }
}

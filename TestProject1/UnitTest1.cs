using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium;
using System.Threading;

namespace Task_3
{
    class Chrome
    {

        //task 1

        /*IWebDriver driver;
        string Url = "http://rozklad.kpi.ua/Schedules/ScheduleGroupSelection.aspx";
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Thread.Sleep(timeout: TimeSpan.FromSeconds(2));
            driver.Url = Url;
        }
        [Test]
        public void TestSearchRozklad()
        {
            IWebElement searchField = driver.FindElement(By.XPath("//*[@id=\"ctl00_MainContent_ctl00_txtboxGroup\"]"));
            searchField.Click();
            searchField.SendKeys(text: "КП-91");
            IWebElement searchButton = driver.FindElement(By.XPath("//*[@id=\"ctl00_MainContent_ctl00_btnShowSchedule\"]"));
            searchButton.Click();
            IWebElement searchLesson = driver.FindElement(By.XPath("//*[@id=\"ctl00_MainContent_FirstScheduleTable\"]/tbody/tr[2]/td[4]/span/a"));
            if (searchLesson.Text.Contains("Компоненти програмної інженерії 2. Якість та тестування програмного забезпечення"))
            {
                Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
            }
            else
            {
                Console.Beep();
            }
            Thread.Sleep(timeout: TimeSpan.FromSeconds(15));
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }*/

        /*//task 2 
        IWebDriver driver;
        string Url = "https://www.google.com/";

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Thread.Sleep(timeout: TimeSpan.FromSeconds(2));
            driver.Url = Url;
        }

        [Test]
        public void TestSearchEpicentr()
        {
            IWebElement googleSearchField = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input"));
            googleSearchField.Click();
            googleSearchField.SendKeys(text: "Епіцентр");
            IWebElement googleSearchButton = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[3]/center/input[1]"));
            googleSearchButton.Click();
            Thread.Sleep(timeout: TimeSpan.FromSeconds(1));
            IWebElement epicentrUrlHref = driver.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div/div/div/div[1]/a"));
            epicentrUrlHref.Click();
            IWebElement epicentrUselessInfo = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/span"));
            epicentrUselessInfo.Click();
            IWebElement epicentrInfo = driver.FindElement(By.XPath("/html/body/div[2]/header/div/div[8]/div/div[2]/div[1]"));
            epicentrInfo.Click();
            IWebElement epicentrContactInfo = driver.FindElement(By.XPath("/html/body/div[2]/header/div/div[8]/div/div[2]/div[2]/a[2]"));
            epicentrContactInfo.Click();
            Thread.Sleep(timeout: TimeSpan.FromSeconds(1));
            IWebElement searchText = driver.FindElement(By.XPath("/html/body/main/div[2]/div/section/h3"));
            if (searchText.Text.Contains("Контакт-центр працює для Вас щоденно з 07:30 до 22:30."))
            {
                Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
            }
            else
            {
                Console.Beep();
            }
            Thread.Sleep(timeout: TimeSpan.FromSeconds(8));
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }*/

        //task 3 
        IWebDriver driver;
        string Url = "https://www.google.com/";

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Thread.Sleep(timeout: TimeSpan.FromSeconds(2));
            driver.Url = Url;
        }

        [Test]
        public void TestSearchRozetka()
        {
            IWebElement googleSearchField = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input"));
            googleSearchField.Click();
            googleSearchField.SendKeys(text: "Rozetka");
            IWebElement googleSearchButton = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[3]/center/input[1]"));
            googleSearchButton.Click();
            Thread.Sleep(timeout: TimeSpan.FromSeconds(1));
            IWebElement rozetkaUrlHref = driver.FindElement(By.XPath("/html/body/div[7]/div/div[9]/div[1]/div/div[2]/div[2]/div/div/div[1]/div/div/div/div/div/div[1]/a"));
            rozetkaUrlHref.Click();
            IWebElement rozetkaSearchInput = driver.FindElement(By.XPath("/html/body/app-root/div/div/rz-header/header/div/div/div/form/div/div/input"));
            rozetkaSearchInput.Click();
            rozetkaSearchInput.SendKeys(text: "Відеокарти");
            IWebElement rozetkaSearchButton = driver.FindElement(By.XPath("/html/body/app-root/div/div/rz-header/header/div/div/div/form/button"));
            rozetkaSearchButton.Click();
            Thread.Sleep(timeout: TimeSpan.FromSeconds(2));
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
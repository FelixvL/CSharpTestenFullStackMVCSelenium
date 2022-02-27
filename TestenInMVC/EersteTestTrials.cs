using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace FullStackRazorMetTestenMVC
{
    [TestFixture]
    public class EersteTestTrials
    {
        IWebDriver driver;
        Actions actions;


        [SetUp]
        public void Setup() {
            //Console.WriteLine("dit is gedaan");
            driver = new ChromeDriver(@"C:\_FILES\kort");
            actions = new Actions(driver);
            driver.Navigate().GoToUrl("http://nos.nl");
        }

        [Test]
        public void EerteTest() {
            Assert.AreEqual(3,4);
            driver.Navigate().GoToUrl("http://nos.nl");
        }
        [TearDown]
        public void TearDown() { 
            driver.Quit();
        }
    }
}

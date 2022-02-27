using FakeItEasy;
using FullStackRazorMetTestenMVC.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;

namespace FullStackRazorMetTestenMVC.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x = A.Fake<ILogger<HomeController>>();
            var a = new HomeController(x);
            var lResult = a.Index() as ViewResult;
            Assert.Equal(lResult.ViewName, "Index");
        }
    }
}
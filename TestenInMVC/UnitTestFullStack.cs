using FullStackRazorMetTestenMVC.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StoreTests.Controllers
{
     [TestClass]
     public class ProductControllerTest
     {
          [TestMethod]
          public void TestDetailsView()
          {
               var controller = new HomeController(null);
               var result = controller.Index() as ViewResult;
               Assert.AreEqual("Details", result.ViewName);

          }
     }
}

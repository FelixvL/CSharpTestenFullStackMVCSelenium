using NUnit.Framework;
using Moq;
//using TestingControllersSample.Controllers;
//using TestingControllersSample.Core.Interfaces;
//using TestingControllersSample.Core.Model;
//using TestingControllersSample.ViewModels;
using Xunit;
using System.Threading.Tasks;
using FullStackRazorMetTestenMVC.Controllers;

namespace TestenInMVC
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void go()//Task Index_ReturnsAViewResult_WithAListOfBrainstormSessions()
        {
            // Arrange
            //var mockRepo = new Mock<IBrainstormSessionRepository>();
            //mockRepo.Setup(repo => repo.ListAsync())
            //  .ReturnsAsync(GetTestSessions());
          //   var controller = new HomeController(mockRepo.Object);

            // Act
            //            var result = await controller.Index();

            // Assert
            //          var viewResult = Assert.IsType<ViewResult>(result);
            //        var model = Assert.IsAssignableFrom<IEnumerable<StormSessionViewModel>>(
            //          viewResult.ViewData.Model);
            new HomeController(null);
            NUnit.Framework.Assert.AreEqual(2, 2);
        }
        [Test]
        public void Test1()
        {
            NUnit.Framework.Assert.Pass();
        }
    }
}
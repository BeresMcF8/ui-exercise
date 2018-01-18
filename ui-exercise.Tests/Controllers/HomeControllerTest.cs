using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ui_exercise;
using ui_exercise.Controllers;

namespace ui_exercise.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void The_Application_Has_An_Index_Page()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void The_Application_Has_An_About_Page()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void The_Application_Has_An_Blog_Page()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Blog() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

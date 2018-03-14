using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContinuousWeb.Controllers;
using System;
using Microsoft.AspNetCore.Mvc;

namespace ContinuousWeb.Tests
{
    [TestClass]
    public class HomeControllerTests
    {        
        [TestMethod]
        public void AboutPageTest()
        {
            var homeController = new HomeController();
            var result = homeController.About();
            //ActionResult result = homeController.About();
            
        }

        [TestMethod ]
        public void CheckNumber()
        {
              int x = 1001;
              Assert.IsTrue( x % 2 == 0, "Result = " + x.ToString() ); 

        }

    }

}

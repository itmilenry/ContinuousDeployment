<<<<<<< HEAD
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContinuousWeb.Controllers;

namespace ContinuousWeb.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void AboutPageTest()
        {
            var homeController = new HomeController();
            var result = homeController.About();
            //ActionResult result = homeController.About();
            
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod ]
        public void CheckNumber()
        {
              int x = 100;
              Assert.IsTrue( x % 2 == 0, "Result = " + x.ToString() ); 

        }

    }
}
=======
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContinuousWeb.Controllers;

namespace ContinuousWeb.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void AboutPageTest()
        {
            var homeController = new HomeController();
            var result = homeController.About();
            //ActionResult result = homeController.About();
            
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod ]
        public void CheckNumber()
        {
              int x = 100;
              Assert.IsTrue( x % 2 == 0, "Result = " + x.ToString() ); 

        }

    }
}
>>>>>>> 029788a3436cfe6e73861d73d6d4a8e1191d54a3

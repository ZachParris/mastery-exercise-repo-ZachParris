using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.Controllers;
using System.Web.Mvc;

namespace RepoQuiz.Tests.Controllers
{
    [TestClass]
    public class StudentControllerTests
    {
        [TestMethod]
        public void Index()
        {
            StudentController controller = new StudentController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.DAL;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class NameGeneratorTests
    {
        [TestMethod]
        public void CanBeInstantiated()
        {
            NameGenerator tester = new NameGenerator();
            Assert.IsNotNull(tester);
        }
    }
}

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

        [TestMethod]
        public void CanGenerateRandomStudent()
        {
            NameGenerator tester = new NameGenerator();
            var student1 = tester.GenerateRandomStudent();
            var student2 = tester.GenerateRandomStudent();
            Assert.AreNotEqual(student1, student2);
        }
    }
}

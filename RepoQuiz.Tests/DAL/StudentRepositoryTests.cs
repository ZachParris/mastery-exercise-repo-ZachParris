using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.DAL;
using System.Collections.Generic;
using RepoQuiz.Models;
using Moq;
using System.Data.Entity;
using System.Linq;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class StudentRepositoryTests
    {
        Mock<StudentContext> mock_context { get; set; }
        Mock<DbSet<Student>> mock_student_table { get; set; }
        List<Student> student_list { get; set; } // Fake
        StudentRepository repo { get; set; }

        public void ConnectMocksToDatastore()
        {
            var queryable_list = student_list.AsQueryable();

            // Lie to LINQ make it think that our new Queryable List is a Database table.
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.Provider).Returns(queryable_list.Provider);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.Expression).Returns(queryable_list.Expression);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.ElementType).Returns(queryable_list.ElementType);
            mock_student_table.As<IQueryable<Student>>().Setup(m => m.GetEnumerator()).Returns(() => queryable_list.GetEnumerator());

            // Have our Author property return our Queryable List AKA Fake database table.
            mock_context.Setup(c => c.Students).Returns(mock_student_table.Object);

            mock_student_table.Setup(t => t.Add(It.IsAny<Student>())).Callback((Student a) => student_list.Add(a));
        }

        [TestInitialize]
        public void Initialize()
        {
            // Create Mock BlogContext
            mock_context = new Mock<StudentContext>();
            mock_student_table = new Mock<DbSet<Student>>();
            student_list = new List<Student>(); // Fake
            repo = new StudentRepository(mock_context.Object);

            ConnectMocksToDatastore();
        }

        [TestCleanup]
        public void TearDown()
        {
            repo = null; 
        }

        [TestMethod]
        public void RepoEnsureCanCreateInstance()
        {
            StudentRepository repo = new StudentRepository();
            Assert.IsNotNull(repo);
        }

        [TestMethod]
        public void RepoEnsureRepoHasContext()
        {
            StudentRepository repo = new StudentRepository();

            StudentContext actual_context = repo.Context;

            Assert.IsInstanceOfType(actual_context, typeof(StudentContext));
        }

        [TestMethod]
        public void RepoEnsureWeHaveNoStudents()
        {
            // Arrange


            // Act
            List<Student> actual_student = repo.GetStudents();
            int expected_student_count = 0;
            int actual_student_count = actual_student.Count;

            // Assert
            Assert.AreEqual(expected_student_count, actual_student_count);
        }
        
    }
}
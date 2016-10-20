using System;
using System.Collections.Generic;
using RepoQuiz.Models;
using System.Linq;
using System.Web;

namespace RepoQuiz.DAL
{
    public class NameGenerator
    {
        private string first_name = "Trent";
        private string last_name = "Smith";
        private string major = "Art";
        Random rnd = new Random();

        // This class should be used to generate random names and Majors for Students.
        // This is NOT your Repository
        // All methods should be Unit Tested :)
        public List<string> FirstName = new List<string>()
        {
            "Hank", "Trent", "Matt", "Benje", "Marcelo", "Molly", "Dorna", "Callan", "Brad", "Norm"
        };

        public List<string> LastName = new List<string>()
        {
            "Parris", "Smith", "Ater", "Casper", "West", "Morrison", "Bruton", "Macdonald", "Bailey", "Chan"
        };

        public List<string> Majors = new List<string>()
        {
            "Computer Science", "Literature", "Physics", "Marketing", "Art", "Political Science", "Polish", "Philosophy"
        };

        public Student GenerateRandomStudent()
        {
            int firstNameIndex = rnd.Next(FirstName.Count());
            int lastNameIndex = rnd.Next(LastName.Count());
            int majorIndex = rnd.Next(Majors.Count());
            Student new_student = new Student() { FirstName = FirstName[firstNameIndex], LastName = LastName[lastNameIndex], Major = Majors[majorIndex]};
            return new_student;
        }
    }
}
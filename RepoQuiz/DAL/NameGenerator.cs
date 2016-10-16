using System;
using System.Collections.Generic;
using RepoQuiz.Models;
using System.Linq;
using System.Web;

namespace RepoQuiz.DAL
{
    public class NameGenerator
    {
        // This class should be used to generate random names and Majors for Students.
        // This is NOT your Repository
        // All methods should be Unit Tested :)
        public List<string> FirstName = new List<string>
        {
            "Zach", "Trent", "Matt", "Benje", "Marcelo", "Molly", "Dorna", "Callan", "Brad", "Norm"
        };

        public List<string> LastName = new List<string>
        {
            "Parris", "Smith", "Ater", "Casper", "West", "Morrison", "Bruton", "Macdonald", "Bailey", "Chan"
        };

        public List<string> Majors = new List<string>
        {
            "Computer Science", "Literature", "Physics", "Marketing", "Art", "Political Science", "Polish", "Philosophy"
        };

    }
}
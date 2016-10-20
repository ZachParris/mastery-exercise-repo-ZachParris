namespace RepoQuiz.Migrations
{
    using DAL;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RepoQuiz.DAL.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RepoQuiz.DAL.StudentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            NameGenerator name_creator = new NameGenerator();
            Student created_student1 = name_creator.GenerateRandomStudent();
            Student created_student2 = name_creator.GenerateRandomStudent();
            Student created_student3 = name_creator.GenerateRandomStudent();
            Student created_student4 = name_creator.GenerateRandomStudent();
            Student created_student5 = name_creator.GenerateRandomStudent();
            Student created_student6 = name_creator.GenerateRandomStudent();
            Student created_student7 = name_creator.GenerateRandomStudent();
            Student created_student8 = name_creator.GenerateRandomStudent();
            Student created_student9 = name_creator.GenerateRandomStudent();
            Student created_student10 = name_creator.GenerateRandomStudent();
            context.Students.AddOrUpdate(
                    s => new { s.FirstName, s.LastName, s.Major },
                    created_student1, created_student2, created_student3, created_student4, created_student5, created_student6, created_student7, created_student8, created_student9, created_student10
                    );
                context.SaveChanges();
            }
    }
}

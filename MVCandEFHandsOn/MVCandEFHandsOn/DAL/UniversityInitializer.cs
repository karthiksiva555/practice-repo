using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCandEFHandsOn.Models;
using System.Data.Entity;

namespace MVCandEFHandsOn.DAL
{
    public class UniversityInitializer:DropCreateDatabaseIfModelChanges<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            //base.Seed(context);

            var students = new List<Student>
            {
                new Student{FirstName="Siva",LastName="Narisetty",EnrollmentDate=DateTime.Parse("2017-05-04") },
                new Student{FirstName="Mani Kanta",LastName="Thota",EnrollmentDate=DateTime.Parse("2010-09-15") },
                new Student{FirstName="Hari Krishna",LastName="Parvathareddy",EnrollmentDate=DateTime.Parse("2012-03-09") }
            };

            var courses = new List<Course>
            {
                new Course{CourseID=1,Title="Environmental Science", Credits=2},
                new Course{CourseID=2,Title="Psychology", Credits=6},
                new Course{CourseID=3,Title="Software Engineering", Credits=10},
                new Course{CourseID=4,Title="Electrical and Architecture", Credits=4}

            };

            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=2,Grade=Grade.B},
                new Enrollment{StudentID=1,CourseID=3,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=1,Grade=Grade.C},
                new Enrollment{StudentID=2,CourseID=2,Grade=Grade.D},
                new Enrollment{StudentID=2,CourseID=4,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=2,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=4,Grade=Grade.C}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            courses.ForEach(c => context.Courses.Add(c));
            context.SaveChanges();
            enrollments.ForEach(e => context.Enrollments.Add(e));
            context.SaveChanges();
        }
    }
}
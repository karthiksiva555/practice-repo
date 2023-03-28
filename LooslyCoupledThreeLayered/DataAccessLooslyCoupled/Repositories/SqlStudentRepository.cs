using DomainModelLooslyCoupled;
using System.Collections.Generic;
using System.Linq;
using DomainModel = DomainModelLooslyCoupled.ModelClasses;
namespace DataAccessLooslyCoupled
{
    public class SqlStudentRepository : StudentRepository
    {
        private readonly UniversityInfo universityInfoContext;

        public SqlStudentRepository() => this.universityInfoContext = new UniversityInfo();
        
        public override IEnumerable<DomainModel.Student> GetDistinctionStudents()
        {
            var students = universityInfoContext.Students.Where(s => s.GPA > (double)4.0).AsEnumerable<Student>();

            return ToDomainStudents(students);
        }

        public IEnumerable<DomainModel.Student> ToDomainStudents(IEnumerable<Student> students)
        {
            var domainStudents = new List<DomainModel.Student>();

            foreach(var student in students)
                domainStudents.Add(new DomainModel.Student { Name = $"{student.FirstName} {student.LastName}", GPA = student.GPA });

            return domainStudents;
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace DataLayerTightCoupled.DAL
{
    public class StudentRepository
    {
        private readonly UniversityInfo objectContext;

        public StudentRepository()
        {
            this.objectContext = new UniversityInfo();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return this.objectContext.Students.ToList();
        }
    }
}

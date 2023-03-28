using System.Collections.Generic;
using System.Linq;
using DataLayerTightCoupled;
using DataLayerTightCoupled.DAL;

namespace BusinessLayerTightCoupled
{
    public class StudentService
    {
        private readonly StudentRepository studentRepository;

        public StudentService()
        {
            this.studentRepository = new StudentRepository();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return this.studentRepository.GetAllStudents().AsEnumerable();
        }
    }
}

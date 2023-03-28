using DomainModelLooslyCoupled.ModelClasses;
using System;
using System.Collections.Generic;

namespace DomainModelLooslyCoupled
{
    public class StudentService
    {
        private readonly StudentRepository _studentRepository;

        public StudentService(StudentRepository repo)
        {
            this._studentRepository = repo ?? throw new ArgumentNullException("Repository is Empty");
        }
        
        public IEnumerable<Student> GetDistinctionStudents()
        {
            return _studentRepository.GetDistinctionStudents();
        }
    }
}

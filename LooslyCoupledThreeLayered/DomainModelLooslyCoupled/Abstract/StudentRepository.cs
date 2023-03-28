using DomainModelLooslyCoupled.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModelLooslyCoupled
{
    public abstract class StudentRepository
    {
        public abstract IEnumerable<Student> GetDistinctionStudents();
    }
}

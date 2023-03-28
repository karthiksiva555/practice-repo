using DomainModelLooslyCoupled;
using LooslyCoupledThreeLayered.Models;
using System;
using System.Web.Mvc;

namespace LooslyCoupledThreeLayered.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentRepository studentRepository;
        
        public StudentController()
        {

        }
        
        public StudentController(StudentRepository repo)
        {
            this.studentRepository = repo ?? throw new ArgumentNullException("Repository is empty");
        }

        // GET: Student
        public ActionResult Index()
        {
            var studentService = new StudentService(studentRepository);
            var students = studentService.GetDistinctionStudents();
            var vm = new DistinctionStudentsViewModel();
            
            //student model to student view model and then to DistinctionStudentViewModel
            foreach (var stud in students)
            {
                var studentViewModel = new StudentViewModel { Name=stud.Name, GPA = stud.GPA, SummaryText = $"{stud.Name} ({stud.GPA})" };
                vm.Students.Add(studentViewModel);
            }
            
            return View(vm);
        }
    }
}
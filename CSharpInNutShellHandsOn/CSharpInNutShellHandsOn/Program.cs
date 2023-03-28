using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInNutShellHandsOn
{
    public class Program
    {
        public static void PrintMetaData(string className)
        {
            Assembly objAssembly = Assembly.GetExecutingAssembly();
            Type t = objAssembly.GetType(className);

            Console.WriteLine("***** Properties *****");
            PropertyInfo[] pi = t.GetProperties();
            foreach (PropertyInfo prop in pi)
                Console.WriteLine("->{0}", prop.Name);

            Console.WriteLine("***** Methods *****");
            MethodInfo[] mi = t.GetMethods();
            foreach (MethodInfo m in mi)
                Console.WriteLine("->{0}", m.Name);

        }

        public static void Main(string[] args)
        {
            //Student st1 = new Student("Siva", 1);
            //Student st2 = new Student("Karthik", 2);
            //Student[] studList = new Student[2] {st1,st2};

            ////IEnumerable Example:
            //MyStudentIEnumerable<Student> students = new MyStudentIEnumerable<Student>(studList);
            //foreach(Student s in students)
            //{
            //    Console.WriteLine($"Student Name: {s.StudentName}, ID: {s.Id}");
            //}

            //ICollection example:

            //List<Student> studs = new List<Student> { new Student("Mag",3), new Student("Ted",5), new Student("Lilly",4)};
            //MyStudentCollection<Student> studCollection = new MyStudentCollection<Student>(studs);
            //Student ted = new Student("Ted", 5);

            //foreach (Student s in studCollection) Console.WriteLine($"Student Name: {s.StudentName} and ID : {s.Id}");

            //Console.WriteLine($"Does the collection contain student Mag? : {studs.Contains<Student>(ted)}");
            //studCollection.Add(new Student("Jagad", 10));
            ////Student item = new Student("Mag", 3);
            ////studCollection.Remove(item);
            ////studs.Remove(item);
            ////studCollection.Clear();

            //foreach (Student s in studCollection) Console.WriteLine($"Student Name: {s.StudentName} and ID : {s.Id}");

            //foreach (Student s in studs) Console.WriteLine($"Student Name: {s.StudentName} and ID : {s.Id}");

            //ICollection<Student> studentCollection = new List<Student>{ new Student("Mag", 3), new Student("Ted", 5), new Student("Lilly", 4) }; 
            //MyGenericCollection<Student> students = new MyGenericCollection<Student>(studentCollection);
            ////students.Add(ted);
            //Console.WriteLine($"Does the collection contain student ted? : {students.Contains<Student>(ted)}");

            //IList<Student> students = new List<Student>();
            //Student ted = new Student("Siva", 1);
            //MyGenericList<Student> studs = new MyGenericList<Student>();
            //studs.Add(new Student("Siva", 1)); studs.Add(new Student("Karthik", 2)); studs.Add(new Student("Narisetty", 3));
            //studs.RemoveAt(1);
            //Console.WriteLine($"Does the collection contain student ted? : {studs.Contains<Student>(ted)}");
            //foreach (Student s in studs) Console.WriteLine($"Student Name: {s.StudentName} and ID : {s.Id}");

            //Swapper sw = new Swapper();
            //int x=10, y=20;
            //sw.Swap<int>(ref x, ref y);
            //Console.WriteLine($"After Swap: x = {x}; y ={y}");

            //string first = "first string", second = "second string";
            //sw.Swap<string>(ref first, ref second);
            //Console.WriteLine($"After Swap: first = {first}; second ={second}");

            //Utility util = new Utility();
            //Console.WriteLine($"The full name is : {util.GetFullName("Cary", "List")}");

            //Person p1 = new Person("David","male");
            //Console.WriteLine($"The name with salutation is: {p1.GetSalutationName()}");

            //Person p2 = new Person("Emily","female");
            //Console.WriteLine($"The name with salutation is: {p2.GetSalutationName()}");

            //Program.PrintMetaData("Reflection.Employee");

            Car audiObj = new Car("Audi R7", "2018");
            Console.WriteLine($"audiObj.ToString() = {audiObj.ToString()}");

            Console.ReadLine();
        }
    }
}

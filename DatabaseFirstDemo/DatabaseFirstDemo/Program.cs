using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var plutoDB = new PlutoEntities();
            var authors = plutoDB.Authors;

            foreach(Author a in authors)
            {
                Console.WriteLine(" Author name"+ a.Name);
            }

            plutoDB.InsertCourse(1, "Chetan Bhagad", "A test insert", 10, "Beginner", 1);
            Console.ReadLine();
        }
    }
}

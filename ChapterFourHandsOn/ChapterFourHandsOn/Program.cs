using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFourHandsOn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int x = 10;
            //string firstName, LastName = String.Empty;
            //firstName = "Siva";LastName = "Karthik";
            //LambdaExpressions le = new LambdaExpressions();
            //Console.WriteLine($"Square of {x} is {le.sqr(x)}");
            //Console.WriteLine($"cube of {x} is {le.cube(x)}");
            //Console.WriteLine($"quadraple of {x} is {le.quadraple(x)}");
            //Console.WriteLine($"length of {firstName} and {LastName} together is {le.length(firstName,LastName)}");

            //le.LengthOfType(firstName); //with string parameter
            //le.LengthOfType(x); //with integer
            //le.DoubleLength<int>(ten => le.LengthOfType(firstName));
            ////le.DoubleLength(ten => le.LengthOfType(ten));
            //le.LoopDemo();
            //le.CorrectedLoopDemo();
            //le.CaptureVariableDemo();

            //EnumeratorsHandsOn.InitializeList();
            EnumeratorsHandsOn.PrintFibonacciSeries();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterThreeHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enums
            //----------------------------------------------------------------------------
            //DerivedInterfaceClass dic = new DerivedInterfaceClass();
            //dic.Undo();
            //((IUndoable)dic).Undo();
            //((InterfaceHandsOn)dic).Undo();

            EnumHandson eh = new EnumHandson();
            //eh.GetDefaultValueOfEnum();
            //eh.EnumConversions();
            //eh.EnumWithflags();
            //eh.EnumValidation();

            //----------------------------------------------------------------------------
            //Generics
            //var stackInt = new Stack<int>();
            //stackInt.Push(43);
            //stackInt.Push(34);
            //stackInt.Push(17);
            //Console.WriteLine($"the last element on the stack is: {stackInt.Pop()}");

            int x = 5, y = 10;
            GenericHandsOn.Swap(ref x, ref y);
            Console.WriteLine($"After the Generic Swap<int> x = {x} and y = {y}:");

            string a = "siva", b = "karthik";
            GenericHandsOn.Swap(ref a, ref b);
            Console.WriteLine($"After the Generic Swap<string> a = {a} and b = {b}:");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace CSharpHandsOnNew
{
    class Program
    {

        static void Main(string[] args)
        {
            //extension method
            //Console.WriteLine("Siva".IsCapitalized());

            //dynamic binding
            //dynamic d = new Duck();
            //d.Quack();

            //Callerinfo attributes
            //CallerInfoAttrExample();

            //pre-processor directives
#if DEBUG
            Console.WriteLine("Preprocessor directive present");
#endif

            Console.ReadLine();
        }

        static void CallerInfoAttrExample([CallerMemberName] string membername = null, [CallerFilePath] string path=null, [CallerLineNumber] int line=0)
        {
            Console.WriteLine(membername);
            Console.WriteLine(path);
            Console.WriteLine(line);
        }
    }

    public static class ExtensionMethod
    {
        public static bool IsCapitalized(this string val)
        {
            if (string.IsNullOrEmpty(val)) return false;

            return char.IsUpper(val[0]); 
        }

    }

    public class Duck: DynamicObject
    {
        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            //return base.TryInvokeMember(binder, args, out result);

            Console.WriteLine(binder.Name + " method was called");
            result = null;
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFourHandsOn
{
    public class LambdaExpressions
    {
        public delegate int Transformer(int i);
        public Transformer sqr = x => x * x;
        public Transformer cube = x => x * x * x;
        public Func<int, int> quadraple = x => x * x * x * x;
        public Func<string, string, int> length = (s1, s2) => s1.Length + s2.Length;

        public void LengthOfType<T>(T x) { Console.WriteLine($"length of {x} is: {x.ToString().Length}");}
        public void DoubleLength<T>(Action<T> a) { Console.WriteLine($"Double lenght of string: {a.ToString().Length + a.ToString().Length}"); }

        int factor = 2;

        public void CaptureVariableDemo()
        {
            factor = 5;
            Func<int, int> factorDemo = x => x * factor;
            factor = 10;
            Console.WriteLine($"the value of 10 multiplied by {factor} is : {factorDemo(factor)}");
        }
        public void LoopDemo()
        {
            Action[] actions = new Action[3];

            for(int i = 0; i < 3; i++)
            {
                actions[i] = () => Console.Write(i);
            }

            foreach (Action a in actions) a();
        }

        public void CorrectedLoopDemo()
        {
            Action[] actions = new Action[3];

            for (int i = 0; i < 3; i++)
            {
                int loopVar = i;
                actions[i] = () => Console.Write(loopVar);
            }

            foreach (Action a in actions) a();
        }
    }
}

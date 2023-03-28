using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFourHandsOn
{
    public class MyList<T>:IEnumerable <T>
    {
        T[] listItems = new T[10];
        public int count;
        public void Add(T item)
        {
            if (count == listItems.Length)
                Array.Resize(ref listItems, listItems.Length + 5);
            listItems[count++] = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i=0;i<count;i++)
                yield return listItems[i];
        }

        IEnumerator IEnumerable.GetEnumerator(){return GetEnumerator();}
    }
    
    public class EnumeratorsHandsOn
    {
        public static void InitializeList()
        {
            MyList<int> integerList = new MyList<int>{30,6,24,65};

            foreach (int i in integerList)
                Console.WriteLine(i);

            Console.ReadLine();
        }

        public static void PrintFibonacciSeries()
        {
            foreach(int fib in Fibs(10))
                Console.WriteLine(fib);
        }

        static IEnumerable<int> Fibs(int fibcount)
        {
            for(int i=0, prev = 1, cur = 1; i<fibcount; i++)
            {
                yield return prev;
                int newfib = prev + cur;
                prev = cur;
                cur = newfib;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterThreeHandson
{

    public class Animal { }
    public class Cat :Animal { }
    public class Dog : Animal { }
    public class GermanSheppard : Dog { }

    public interface IPoppable<out T> { T Pop(); }
    public interface IPushable<in T> { void Push(T obj); }

    public class Stack<T> : IPoppable<T>, IPushable<T>
    {
        int position;
        T[] data = new T[100];
        public void Push(T value) => data[position++] = value;
        public T Pop() => data[--position];
    }

    public class GenericHandsOn
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public void CoandContraVariance()
        {
            // The below is possible
            Dog d = new Dog();
            Animal a = d; // animal is the base class, hence can store a dog

            Animal aa = new Animal();
            Cat c = (Cat)aa; // an animal can also be converted to cat explicitly

            //Below is not possible even with casting
            Stack<Dog> dogs = new Stack<Dog>();
            Stack<Animal> animalscheck = dogs;
            IPoppable<Animal> animalsInterface = dogs; // Works!
            
            Stack<Animal> animals = new Stack<Animal>();
            Stack<Cat> cats = (Stack<Cat>)animals;
            IPushable<Cat> catspushable = animals;
            catspushable.
        }

    }
}

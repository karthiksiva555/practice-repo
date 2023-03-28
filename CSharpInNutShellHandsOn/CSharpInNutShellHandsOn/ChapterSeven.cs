using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal HourlyPay { get; set; }
        public decimal GetSalary()
        {
            return this.HourlyPay * 21;
        }
    }
}

namespace CSharpInNutShellHandsOn
{
    public class Student
    {
        public string StudentName { get; set; }
        public int Id { get; set; }

        public Student(string name, int id)
        {
            this.Id = id;
            this.StudentName = name;
        }
    }

    public class MyStudentIEnumerable<Student> : IEnumerable<Student>
    {
        Student[] objList;

        public MyStudentIEnumerable(Student[] val)
        {
            this.objList = val;
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach(Student s in objList)
            {
                yield return s;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class MyStudentCollection<Student> : ICollection<Student>
    {
        List<Student> studCollection;

        public MyStudentCollection(List<Student> val) => this.studCollection = val;
        
        public int Count => studCollection.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Student item) => studCollection.Add(item);
        
        public void Clear() => studCollection.Clear();
        
        public bool Contains(Student item)=> studCollection.Contains(item);
        
        public void CopyTo(Student[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (Student s in studCollection) yield return s;
        }
        
        public bool Remove(Student item) => studCollection.Remove(item);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }

    public class MyGenericCollection<T> : ICollection<T>
    {
        ICollection<T> _items;

        public MyGenericCollection(ICollection<T> items) {
            this._items = items;
        }

        public MyGenericCollection()
        {
            _items = new List<T>();
        }

        public int Count => _items.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _items) yield return item;
        }

        public bool Remove(T item)
        {
            return _items.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class MyGenericList<T> : IList<T>
    {
        IList<T> _list;

        public MyGenericList(IList<T> list)
        {
            _list = list;
        }

        public MyGenericList()
        {
            _list = new List<T>();
        }

        public T this[int index] { get => _list[index]; set => _list[index]=value; }

        public int Count => _list.Count;

        public bool IsReadOnly => false;

        public void Add(T item) => _list.Add(item);

        public void Clear() => _list.Clear();

        public bool Contains(T item) => _list.Contains(item);
        
        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in _list) yield return item;
        }

        public int IndexOf(T item) => _list.IndexOf(item);

        public void Insert(int index, T item) => _list.Insert(index, item);

        public bool Remove(T item) => _list.Remove(item);

        public void RemoveAt(int index) => _list.RemoveAt(index);
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class ChapterSeven
    {
        
    }

    public class Swapper
    {
        public void Swap<T>(ref T a, ref T b)
        {
            T c;
            c = a;
            a = b;
            b = c;
        }
    }

    public class Utility
    {
        public string GetFullName(string first, string last) => last + ", " + first;
    }

    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        public Person(string name, string gender)
        {
            this.Name = name;
            this.Gender = gender;
        }
    }

    public static class ExtensionUtil
    {
        public static string GetSalutationName(this Person p)
        {
            string salutation = (p.Gender.ToLower() == "male") ?"Mr.":"Ms.";
            return salutation + p.Name;
            
        }
    }

    public class Car
    {
        public string  Name { get; set; }
        public string  Model { get; set; }

        public Car(string name, string model)
        {
            this.Name = name;
            this.Model = model;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
    
}

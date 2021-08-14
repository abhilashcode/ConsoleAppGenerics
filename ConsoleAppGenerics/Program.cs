using System;
using System.Collections.Generic;

namespace ConsoleAppGenerics
{

    class CompareLogic
    {
        public static bool Compare<T>(T a1, T a2)
        {
            return a1.Equals(a2);
        }
    }
    class Add<T>
    {
       
    }
    class Vehicle<T>
    {

        static List<T> list = new List<T>();        
        public static void AddList(T _list)
        {
           // list.Add(_list);
           // list.Add(_list);
        }
        public static void getCount()
        {
          //  Console.WriteLine(list.Count);
        }
        
        public static void getCount11()
        {
           // Console.WriteLine(list.Count);
        }
    } 

    class DataStore<T>
    {
        public DataStore(int size)
        {
            _array = new T[size];
        }       
        private T[] _array { get; set; }
        public void AddElement(int _index, T _element)
        {
            _array[_index] = _element;
        }        
        public T GetElement(int _index)
        {
            return _array[_index];
        }
        public T[] GetArray()
        {
            return _array;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CompareLogic.Compare<string>("AB", "CD");
            Vehicle<string>.AddList("ABC");
            Vehicle<int>.AddList(1111);

            DataStore<int> ds = new DataStore<int>(5);

            ds.AddElement(0, 1);
            int a= ds.GetElement(0);
           // Console.Write("Its a : {0}",a);
           // Console.Write("Its a : {0}",a);
           // Console.Write("Its a : {0}",a);
        }
    }
}

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using generics;
using System;
namespace CollectionProject
{
    class Generics
    {
        public bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))

                return true;
            return false;
        }
        //static void Main()
        //{
        //    Generics obj = new Generics();
        //    bool Result = obj.Compare<double>(20.52f, 10.55);
        //    Console.WriteLine(Result);
        //    bool Result2 = obj.Compare<int>(20, 10);
        //    Console.WriteLine(Result2);
        //    Console.ReadLine();

        //}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
   class generics2
    {
        public void Add<T>(T a,T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1+ d2);                                                                                                      
        }
        public void Sub<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void Mul<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void Div<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
      static public void Main(string[] args)
        {
            generics2 obj = new generics2();
            obj.Add<int>(10, 30);
            obj.Sub<double>(15.76, 32.46);
            obj.Mul<float>(10.52f, 30);
            obj.Div<int>(10, 3);
        }
    }
}

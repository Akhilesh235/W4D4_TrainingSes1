using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D4_Training_Ses1 // Generics Sample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Before Swapping");
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            
            swap<int>(ref a, ref b);

            Console.WriteLine("After Swapping");
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);


            
            Console.WriteLine("Before Swapping");
            Console.WriteLine("c: " + c);
            Console.WriteLine("d: " + d);

            swap<float>(ref c, ref d);

            Console.WriteLine("After Swapping");
            Console.WriteLine("c: " + c);
            Console.WriteLine("d: " + d);

           
            
            Console.WriteLine("Before Swapping");
            Console.WriteLine("s1: " + s1);
            Console.WriteLine("s2: " + s2);

            swap<string>(ref s1, ref s2);

            Console.WriteLine("After Swapping");
            Console.WriteLine("s1: " + s1);
            Console.WriteLine("s2: " + s2);

        }

        //public static void swap(int a, int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}

        //Writing Generic Method
        public static void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}

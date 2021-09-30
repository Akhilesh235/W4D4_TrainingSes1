using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D4_Training_Ses1 // Generics Sample
{
    class Parent
    {

    }

    class child : Parent
    {
        
    }

    class grandchild : child
    {

    }

    class something
    {

    }
    
    public class Device<T> where T : child
    {
        public T name { get; set; }
        public T category { get; set; }
    }

    public class SampleClass<T>
    {
        T[] arrObj = new T[5];
        int count = 0;

        //Add
        public void Add(T item)
        {
            if (count + 1 < 5)
            {
                arrObj[count] = item;
            }
            count++;
        }

        //indexer
        public T this[int index]
        {
            get { return arrObj[index]; }
            set { arrObj[index] = value; }
        }
    }



    class Program
    {
      
        
        static void Main(string[] args)
        {
            //GenericAtClassLevel();
            GenericAtFunctionInsideClass();
            Console.ReadLine();


        }

        private static void GenericAtFunctionInsideClass()
        {
            SampleClass<float> floatclass = new SampleClass<float>;
            floatclass.Add(3.4f);
            floatclass.Add(2.4f);
            floatclass.Add(1.4f);

            for(int i = 0; i<3; i++)
            {
                Console.WriteLine(floatclass[i]);
            }

            SampleClass<int> intclass = new SampleClass<int>;
            intclass.Add(3);
            intclass.Add(2);
            intclass.Add(1);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(intclass[i]);
            }
        }
        private static void GenericAtClassLevel()
        {
           //classname<type> objectname = new classname<type>();
            Device<Parent> intObj = new Device<Parent>();
            Device<child> floatObj = new Device<child>();
            Device<something> stringobj = new Device<something>();

            intObj.name = 1;
            intObj.category = 2;

            floatObj.name = 5.1f;
            floatObj.category = 4.2f;
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

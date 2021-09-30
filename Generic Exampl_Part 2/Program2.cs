using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Exampl_Part_2
{

    //public interface IMyGenericInterface<T>     //how to define Generic Interface
    //{
    //    void dosomething(T a, T b);

    //    T dosomethingelse(T a, T b);

    //}


    ////First way to create a class of Generic Interface --> implementing generic interface
    //public class MyGenericClass : IMyGenericInterface<int>
    //{
    //    public void dosomething(int a, int b)
    //    {
    //        throw new NotImplementedException();

    //    }

    //    public int dosomethingelse(int a, int b)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


    ////Second way to create a class of generic interface -->
    //public class MyGenericClass1<T> : IMyGenericInterface<T>
    //{
    //    public void dosomething(T a, T b)
    //    {
    //        throw new NotImplementedException();

    //    }

    //    public T dosomethingelse(T a, T b)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class Program2
    //{
    //    public void creategenerictypes()
    //    {
    //        MyGenericClass mygenericclass = new MyGenericClass();
    //        mygenericclass.dosomething(1, 1);

    //        MyGenericClass1<int> intmyGenericClass1 = new MyGenericClass1<int>();
    //        intmyGenericClass1.dosomething(1, 2);

    //        MyGenericClass1<float> floatmyGenericClass1 = new MyGenericClass1<float>();
    //        floatmyGenericClass1.dosomething(1.3f, 3.4f);

    //    }
       
    //}
}

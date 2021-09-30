using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Exampl_Part_2
{
    public interface Numbers<T>     //how to define Generic Interface
    {
        T add(T a, T b);

        
    }

    public class NumbersClass<T> : Numbers<T>
    {
        public T add (T a, T b)
        {
            throw new NotImplementedException();
        }
    }


    class Generic_Example_3
    {
        public void AddNumbers()
        {
            NumbersClass<int> myNumberClass = new NumbersClass<int>();
            myNumberClass.add(1, 1);

        }
    }
}

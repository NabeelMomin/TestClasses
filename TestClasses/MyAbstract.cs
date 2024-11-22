using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
    public abstract class MyAbstract
    {
        public MyAbstract()
        {
            Console.WriteLine("MyAbstractor Constructor");
        }
        public MyAbstract(int a)
        {
        }
        public abstract string MyAbdtractProperty { get; }
        public void Normal()
        {
        }
        public abstract void MyAbstractMethod();
    }
}

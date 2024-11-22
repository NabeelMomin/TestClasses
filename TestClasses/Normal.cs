using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
    public class Normal : MyAbstract, IShape
    {
        public override string MyAbdtractProperty { get; }

        public void Circle()
        {
            throw new NotImplementedException();
        }

        public override void MyAbstractMethod()
        {
            
        }
        
    }
    public interface IShape
    {
        void Circle();
    }
}

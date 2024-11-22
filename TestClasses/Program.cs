using System.Collections;

namespace TestClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToInt32(Color.Red));
        }
        public enum Color
        {
            Red=101,
            Green=108,
            yellow=115
        }
    }
}

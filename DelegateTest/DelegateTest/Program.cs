using System;

namespace DelegateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Test();
            var a = Console.ReadLine();
            var b = Console.ReadLine();

            test.print(a,b);
            Console.ReadKey();
        }
    }
        
    public delegate string StringAction(string a, string b);

    public delegate int IntegerAction(int a, int b);

    public class Test
    {
        public static string CombineTwoStrings(string a, string b)
        {
            return a+b;
        }

        private readonly StringAction m_CombineTwoStrings = CombineTwoStrings;

        private StringAction SA = (a, b) => a + b;

        private IntegerAction IA = (a, b) => a + b;

        public void print(string a, string b)
        {
            Console.WriteLine("CombineString: {0}",m_CombineTwoStrings(a,b));
            Console.WriteLine("SA: {0}", SA(a, b));
            Console.WriteLine("IA: {0}", IA(Convert.ToInt32(a), Convert.ToInt32(b)));
        }
    }

}

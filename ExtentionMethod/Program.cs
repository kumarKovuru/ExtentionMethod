using System;

namespace ExtentionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MathsClassLibrary.MathLibrary math = new MathsClassLibrary.MathLibrary();
            string input = "Kumar";
            Console.WriteLine(math.Sum(2, 3));
            Console.WriteLine(math.Subs(12, 3));
            Console.WriteLine(input.isCharExists('a', 'i', 'e', 'o', 'u'));
            Console.ReadKey();
        }
    }
}

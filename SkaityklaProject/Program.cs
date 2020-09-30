using System;

namespace SkaityklaProject
{
    class Program
    {
        class Test
        {
            public string MyTest { get; set; }

            public void SetTest()
            {
                Console.WriteLine( "input test" );
                MyTest = Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Test test = new Test();
            Test test2 = new Test();
            test.SetTest();
            test2.SetTest();
            Console.WriteLine();
            Console.WriteLine(test.MyTest);
            Console.WriteLine(test2.MyTest);
        }
    }
}

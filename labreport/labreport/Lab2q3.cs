using System;

namespace DotNetLab
{
    public partial class Lab2q3
    {
        public void MethodB()
        {
            Console.WriteLine("This is Method B from part 2.");
        }

        public static void Run()
        {
            Lab2q3 demo = new Lab2q3();
            demo.MethodA();
            demo.MethodB();
        }
    }
}

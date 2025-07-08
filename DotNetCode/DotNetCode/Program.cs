//using System;

//namespace Unit4
//{
//    class OddNumberException : Exception
//    {
//        public override string Message
//        {
//            get
//            {
//                return "Oops... Odd Number Occurred";
//            }
//        }
//    }

//    class CustomExceptionDemo
//    {
//        //static void Main(string[] args)
//        {
//            int a, b, c;

//            try
//            {
//                Console.WriteLine("Enter any two numbers:");
//                a = int.Parse(Console.ReadLine());
//                b = int.Parse(Console.ReadLine());

//                if (b == 0)
//                {
//                    throw new DivideByZeroException("Cannot divide by zero");
//                }

//                if (b % 2 != 0)
//                {
//                    throw new OddNumberException();
//                }

//                c = a / b;
//                Console.WriteLine("Result: " + c);
//            }
//            catch (OddNumberException one)
//            {
//                Console.WriteLine(one.Message);
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Input must be a valid integer.");
//            }
//            catch (DivideByZeroException dz)
//            {
//                Console.WriteLine(dz.Message);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("An unexpected error occurred: " + e.Message);
//            }
//        }
//    }
//}

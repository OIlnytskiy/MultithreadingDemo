//using System;
//using System.Threading;

//namespace Multithreading
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var t = new Thread(PrintNumbers);
//            t.Start();
//            PrintNumbers();
//            Console.ReadKey();
//        }

//        static void PrintNumbers()
//        {
//            Console.WriteLine("Starting...");
//            for (var i = 1; i < 10; i++)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}

///*
// * Задачі працюють на основі черги
// * TP ініціалізує ОС до старту прграми
// * Якщо тридів не хватає вони автоматично створюються
// * Тріди які простоюють автоматично видаляються
// * 
// */

//using System;
//using System.Threading;

//namespace Multithreading
//{
//    public class Fibonacci
//    {
//        public Fibonacci(int n, ManualResetEvent doneEvent)
//        {
//            _n = n;
//            _doneEvent = doneEvent;
//        }

//        public void ThreadPoolCallback(Object threadContext)
//        {
//            var threadIndex = (int)threadContext;
//            Console.WriteLine("thread {0} started...", threadIndex);
//            _fibOfN = Calculate(_n);
//            Console.WriteLine("thread {0} result calculated...", threadIndex);
//            _doneEvent.Set();
//        }

//        public int Calculate(int n)
//        {
//            if (n <= 1)
//            {
//                return n;
//            }

//            return Calculate(n - 1) + Calculate(n - 2);
//        }

//        public int N
//        {
//            get { return _n; }
//        }

//        private int _n;

//        public int FibOfN
//        {
//            get { return _fibOfN; }
//        }

//        private int _fibOfN;

//        private ManualResetEvent _doneEvent;
//    }

//    public class ThreadPoolExample
//    {
//        private static void Main()
//        {
//            const int fibonacciCalculations = 10;

//            var doneEvents = new ManualResetEvent[fibonacciCalculations];
//            var fibArray = new Fibonacci[fibonacciCalculations];
//            var r = new Random();

//            Console.WriteLine("launching {0} tasks...", fibonacciCalculations);
//            for (var i = 0; i < fibonacciCalculations; i++)
//            {
//                doneEvents[i] = new ManualResetEvent(false);
//                var f = new Fibonacci(r.Next(20, 40), doneEvents[i]);
//                fibArray[i] = f;
//                ThreadPool.QueueUserWorkItem(f.ThreadPoolCallback, i);
//            }

//            WaitHandle.WaitAll(doneEvents);
//            Console.WriteLine("All calculations are complete.");

//            for (var i = 0; i < fibonacciCalculations; i++)
//            {
//                var f = fibArray[i];
//                Console.WriteLine("Fibonacci({0}) = {1}", f.N, f.FibOfN);
//            }
//            Console.ReadKey();
//        }
//    }
//}
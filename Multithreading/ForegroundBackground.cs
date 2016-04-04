//using System;
//using System.Threading;

//namespace Multithreading
//{
//    class ForegroundBackground
//    {
//        static void Main(string[] args)
//        {
//            var sampleForeground = new ThreadSample(10);
//            var sampleBackground = new ThreadSample(20);
//            var threadOne = new Thread(sampleForeground.CountNumbers);
//            threadOne.Name = "ForegroundThread";
//            var threadTwo = new Thread(sampleBackground.CountNumbers);
//            threadTwo.Name = "BackgroundThread";
//            threadTwo.IsBackground = true;
//            threadOne.Start();
//            threadTwo.Start();
//            Console.ReadKey();
//        }
//    }

//    class ThreadSample
//    {
//        private readonly int _iterations;
//        public ThreadSample(int iterations)
//        {
//            _iterations = iterations;
//        }
//        public void CountNumbers()
//        {
//            for (var i = 0; i < _iterations; i++)
//            {
//                Thread.Sleep(TimeSpan.FromSeconds(0.5));
//                Console.WriteLine("{0} prints {1}",
//                Thread.CurrentThread.Name, i);
//            }
//        }
//    }
//}

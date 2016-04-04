using System;
using System.Threading.Tasks;

namespace Multithreading
{
    class UsingTask
    {
        static void Main(string[] args)
        {
            var task = new Task(DoSomething);
            task.Start();
            task.Wait();
            Console.ReadKey();
        }

        static async void DoSomething()
        {
            Task<string> longRunningTask = LongRunningOperationAsync();
            string result = await longRunningTask;
            Console.WriteLine(result);
        }

        public static async Task<string> LongRunningOperationAsync()
        {
            await Task.Delay(1000);
            return "Hello";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSynchronization
{
    public class ThreadSynchronizationSemaphoreSlim
    {
        static SemaphoreSlim semaphore = new SemaphoreSlim(initialCount: 3);
       public static void CallThread()
        {
            for (int i = 1; i <= 5; i++)
            {
                int count = i;
                Thread t = new Thread(() => SemaphoreSlimFunction("Thread " + count, 1000 * count));
                t.Start();
            }
            Console.ReadLine();
        }
        static void SemaphoreSlimFunction(string name, int seconds)
        {
            Console.WriteLine($"{name} Waits to access resource");
            semaphore.Wait();
            Console.WriteLine($"{name} was granted access to resource");
            Thread.Sleep(seconds);
            Console.WriteLine($"{name} is completed");
            semaphore.Release();
        }
    }
}

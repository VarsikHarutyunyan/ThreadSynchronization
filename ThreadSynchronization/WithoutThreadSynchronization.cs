using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSynchronization
{
    public class WithoutThreadSynchronization
    {
       public static void CallThread()
        {
            Thread thread1 = new Thread(SomeMethod)
            {
                Name = "Thread 1"
            };

            Thread thread2 = new Thread(SomeMethod)
            {
                Name = "Thread 2"
            };

            Thread thread3 = new Thread(SomeMethod)
            {
                Name = "Thread 2"
            };

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
        public static void SomeMethod()
        {
            Console.WriteLine("[Welcome To The " +  System.Environment.CurrentManagedThreadId);
             Thread.Sleep(1000);
            Console.WriteLine("World of Dotnet!] "+  System.Environment.CurrentManagedThreadId);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSynchronization
{
    public class ThreadSynchronizationSemaphore
    {
        public static Semaphore semaphore = null;
       public static void CallThread()
        {
            try
            {
                //Try to Open the Semaphore if Exists, if not throw an exception
                semaphore = Semaphore.OpenExisting("SemaphoreDemo");
            }
            catch (Exception Ex)
            {
                //If Semaphore not Exists, create a semaphore instance
                //Here Maximum 2 external threads can access the code at the same time
                semaphore = new Semaphore(2, 2, "SemaphoreDemo");
            }
            Console.WriteLine("External Thread Trying to Acquiring");
            semaphore.WaitOne();
            //This section can be access by maximum two external threads: Start
            Console.WriteLine("External Thread Acquired");
            Console.ReadKey();
            //This section can be access by maximum two external threads: End
            semaphore.Release();
        }
    }
}

using ThreadSynchronization;

Console.WriteLine("Start  Thread Synchronization !");


//WithoutThreadSynchronization.CallThread();

//ThreadSynchronizationLock.CallThread();
//ThreadSynchronizationMonitor.CallThread();
ThreadSynchronizationMutex.CallThread();
//ThreadSynchronizationSemaphore.CallThread();

//ThreadSynchronizationSemaphoreSlim.CallThread();
Console.WriteLine("End Thread Synchronization !");

Console.ReadKey();
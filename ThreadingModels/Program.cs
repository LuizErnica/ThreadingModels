using System.Diagnostics;

namespace ThreadingModels
{
    internal class Program
    {
        private static int _counter = 0; // Shared variable accessed by multiple threads
        private static Lock _lock = new(); // Lock object for synchronizing access to the shared counter
        private delegate void IncrementTest(); // Delegate type for incrementing the counter, used to define the method signature for increment operations
        private const int _THREAD_NUM = 10; // Number of threads to create for concurrent execution
        private const int _ITERATIONS = 100000; // Number of increments each thread will perform on the shared counter

        /// <summary>
        /// Increments the internal counter by 100,000.
        /// </summary>
        /// <remarks>This method is static and modifies a shared counter. If called concurrently from
        /// multiple threads, external synchronization is required to avoid race conditions.</remarks>
        private static void Increment()
        {
            for (int i = 0; i < _ITERATIONS; i++)
            {
                _counter++;
            }
        }

        /// <summary>
        /// Increments the shared counter variable in a thread-safe manner using a lock to ensure exclusive access.
        /// </summary>
        /// <remarks>This method demonstrates how to safely update a shared resource from multiple threads
        /// by synchronizing access with a lock. Use this approach to prevent race conditions when incrementing counters
        /// or modifying shared state in multithreaded scenarios.</remarks>
        private static void IncrementUsingLock()
        {
          for (int i = 0; i < _ITERATIONS; i++)
            {
                lock (_lock)
                {
                    _counter++;
                }
            }
        }

        /// <summary>
        /// Atomically increments the value of the shared counter variable a fixed number of times using interlocked
        /// operations.
        /// </summary>
        /// <remarks>This method demonstrates the use of thread-safe increment operations to avoid race
        /// conditions when updating a shared variable in a multithreaded environment. The method is intended for
        /// internal use and is not thread-blocking.</remarks>
        private static void IncrementUsingInterlocked()
        {
            for (int i = 0; i < _ITERATIONS; i++)
            {
                Interlocked.Increment(ref _counter);
            }
        }

        /// <summary>
        /// Print results of the increment test, including the expected value, calculated value, and elapsed time in milliseconds and ticks.
        /// </summary>
        /// <param name="sw"></param>
        private static void PrintResults(Stopwatch sw)
        {
            int expected = _THREAD_NUM * _ITERATIONS;

            Console.WriteLine($"Expected value  : {expected,15:N0}");
            Console.ForegroundColor = (expected == _counter) ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"Calculated value: {_counter,15:N0}");
            Console.ResetColor();
            Console.WriteLine($"Elapsed time    : {sw.ElapsedMilliseconds,15:N0} ms");
            Console.WriteLine($"Elapsed time    : {sw.ElapsedTicks,15:N0} ticks");
        }

        /// <summary>
        /// Executes the specified increment test concurrently across multiple threads and reports the results.
        /// </summary>
        /// <remarks>This method creates and starts multiple threads to perform the increment operation in
        /// parallel, then waits for all threads to complete before reporting the expected and actual results. Use this
        /// method to evaluate the thread safety and performance of increment operations under concurrent
        /// conditions.</remarks>
        /// <param name="test">The increment test delegate to invoke on each thread. Cannot be null.</param>
        private static void RunMultiThreadTest(IncrementTest test)
        {
            Thread[] threads = new Thread[_THREAD_NUM]; // Array to hold references to the created threads for later synchronization
            var sw = Stopwatch.StartNew(); // Stopwatch to measure the elapsed time for the concurrent execution of the increment test

            _counter = 0; // Reset the shared counter to zero before starting the test to ensure accurate results

            // Create and start multiple threads to perform the increment operation concurrently.
            for (int i = 0; i < _THREAD_NUM; i++)
            {
                threads[i] = new Thread(test.Invoke);
                threads[i].Start();
            }

            // Wait for all threads to complete their execution before proceeding.
            for (int i = 0; i < _THREAD_NUM; i++)
            {
                threads[i].Join();
            }

            sw.Stop();

            PrintResults(sw);
        }

        /// <summary>
        /// Executes the specified increment test concurrently across parallel execution and reports the results.
        /// </summary>
        /// <param name="test"></param>
        private static void RunParallelTest(IncrementTest test)
        {
            var sw = Stopwatch.StartNew(); // Stopwatch to measure the elapsed time for the concurrent execution of the increment test

            _counter = 0; // Reset the shared counter to zero before starting the test to ensure accurate results

            // Perform the increment operation using Parallel execution.
            Parallel.For(0, _THREAD_NUM, _ =>
            {
                test.Invoke();
            });

            sw.Stop();

            PrintResults(sw);
        }

        /// <summary>
        /// Executes the specified increment test concurrently across Tasks and reports the results.
        /// </summary>
        /// <param name="test"></param>
        private static void RunTasksTest(IncrementTest test)
        {
            var sw = Stopwatch.StartNew(); // Stopwatch to measure the elapsed time for the concurrent execution of the increment test

            _counter = 0; // Reset the shared counter to zero before starting the test to ensure accurate results

            // Create and start multiple Tasks to perform the increment operation concurrently.
            Task[] tasks = new Task[_THREAD_NUM];

            for (int i = 0; i < _THREAD_NUM; i++)
            {
                tasks[i] = Task.Run(() =>
                {
                    test.Invoke();
                });
            }

            // Wait for all Tasks to complete their execution before proceeding.
            Task.WaitAll(tasks);

            sw.Stop();

            PrintResults(sw);
        }

        /// <summary>
        /// Serves as the entry point for the application.
        /// </summary>
        /// <remarks>Initializes and starts multiple threads to perform concurrent operations, then waits
        /// for all threads to complete before displaying the expected and calculated results. This method is typically
        /// called automatically by the runtime and should not be invoked directly.</remarks>
        static void Main()
        {
            Console.WriteLine("\nWithout synchronization:");
            RunMultiThreadTest(Increment);

            Console.WriteLine("\nSynchronization using lock:");
            RunMultiThreadTest(IncrementUsingLock);

            Console.WriteLine("\nSynchronization using Interlocked:");
            RunMultiThreadTest(IncrementUsingInterlocked);

            Console.WriteLine("\nUsing Parallel.For & lock:");
            RunMultiThreadTest(IncrementUsingLock);

            Console.WriteLine("\nUsing Parallel.For & Interlocked:");
            RunMultiThreadTest(IncrementUsingInterlocked);

            Console.WriteLine("\nUsing Tasks & lock:");
            RunTasksTest(IncrementUsingLock);

            Console.WriteLine("\nUsing Tasks & Interlocked:");
            RunTasksTest(IncrementUsingInterlocked);
        }
    }
}

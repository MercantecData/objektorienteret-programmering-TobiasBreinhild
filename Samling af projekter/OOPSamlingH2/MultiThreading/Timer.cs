using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Timer
    {

        public static Task timerThingy(int seconds, int numberOfRepeats, string text)
        {

            Task task = new Task(() =>
            {
                int timeLeft = 10;

                for (int i = 0; i < numberOfRepeats; i++)
                {
                    Task.Delay(seconds * 1000).Wait();
                    Console.WriteLine(text + timeLeft--);

                    if (timeLeft == 0)
                    {
                        _ = StopTimer();
                    }
                }
            });

            task.Start();

            return task;
        }

        static async Task StopTimer()
        {
            var tokenSource2 = new CancellationTokenSource();

            CancellationToken ct = tokenSource2.Token;

            var task = Task.Run(() =>
            {
                ct.ThrowIfCancellationRequested();

                bool moreToDo = true;
                while (moreToDo)
                {
                    if (ct.IsCancellationRequested)
                    {
                        ct.ThrowIfCancellationRequested();
                    }
                }
            }, tokenSource2.Token);

            tokenSource2.Cancel();

            try
            {
                await task;
            }
            catch (OperationCanceledException e)
            {
                Console.WriteLine("No more guessing for you!");
            }
            finally
            {
                tokenSource2.Dispose();
            }

            Environment.Exit(0);
        }
    }
}

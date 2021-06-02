using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/// <summary>
/// This program is designed to help with the understanding of how parrellel threading works.
/// </summary>
namespace HW11
{
    class Program
    {
        //The excetable of the file
        static async Task Main(string[] args)
        {
            //Creates instances of the all the timers
            Console.WriteLine("Start Asynchronus timer0");
            StartTimerSync(0, 3);
            Console.WriteLine("Timer0 is done");
            Console.WriteLine("Starting Syncronus timer1");
            Task timer1 = StartTimerAsync(1,7);
            Console.WriteLine("Start Asynchronus timer2");
            Task timer2 = StartTimerAsync(2, 7);
            
            //Calls the timers 1 and 2 after they have been waiting to run
            await timer1;
            await timer2;
            Console.WriteLine("Timer1 is done");
            Console.WriteLine("Timer2 is done");
            Console.WriteLine("All timers have completed in the same thread");

            //Creates Timers that can run when call after the delay
            var run1 = Task.Run(() => StartTimerAsync(3, 2));
            var run2 = Task.Run(() => StartTimerAsync(4, 2));

            //Calls the timers that have been waiting to run
            await run1;
            await run2;
            Console.WriteLine("Timer3 is done");
            Console.WriteLine("Timer4 is done");
            Console.WriteLine("All timers have completed in parrallel threads");
        }

        //Creates a timer that can be called and ran after the dealy
        public static void StartTimerSync(int timerId, int countDown)
        {
            for (int count = countDown; count > 0; count--)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Timer{0}: {1}", timerId, count);
             }
        }
        //Creates a timer that must be called using task and await in another async method
        public static async Task StartTimerAsync(int timerId, int countDown)
        {
            for (int  count = countDown; count >0; count--)
            {
                await Task.Delay(1000);
                Console.WriteLine("Timer{0}: {1}", timerId, count);
            }          
        }
    }
}

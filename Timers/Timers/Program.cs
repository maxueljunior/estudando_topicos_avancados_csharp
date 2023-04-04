using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Timers;
using System.Threading;

namespace Timers
{
    internal class Program
    {
        /*
         * Apenas o timer sem o threading...
         * 
         * static void TimerTick(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
        }*/

        static void TimerTick(object state)
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
        }

        static void Main(string[] args)
        {
            TimerCallback tcb = new TimerCallback(TimerTick);
            Timer meuTimer = new Timer(tcb, null, 0, 1000);

            Console.ReadKey();

            meuTimer.Dispose();

            Console.ReadKey();

            /*
             * Apenas timer sem threading...
             * 
             * 
             * Timer timer = new Timer(1000);
            timer.AutoReset = true;
            timer.Elapsed += TimerTick;
            timer.Start();

            Console.ReadKey();

            timer.Stop();

            Console.ReadKey();*/
        }
    }
}

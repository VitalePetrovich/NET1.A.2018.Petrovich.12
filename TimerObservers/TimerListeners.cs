using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET1.A._2018.Petrovich._12;

namespace TimerListeners
{
    /// <summary>
    /// Test listener for timer.
    /// </summary>
    public class TimerListener1
    {
        private static int countListeners = 0;

        private readonly int countCurrentListener;

        /// <summary>
        /// Register listener to timer.
        /// </summary>
        /// <param name="timer">Timer.</param>
        public void Register(Timer timer)
            => timer.TimerEvent += Msg;
        
        /// <summary>
        /// Unregister listener to timer.
        /// </summary>
        /// <param name="timer">Timer.</param>
        public void Unregister(Timer timer)
            => timer.TimerEvent -= Msg;

        public TimerListener1(Timer timer)
        {
            timer.TimerEvent += Msg;
            countCurrentListener = countListeners++;
        }
        
        private void Msg(object sender, TimerInfoEventArgs infoEventInfo)
        {
            Console.WriteLine($"Listener{countCurrentListener + 1}: {infoEventInfo.Message}");
        }
    }

    public class TimerListener2
    {
        /// <summary>
        /// Register listener to timer.
        /// </summary>
        /// <param name="timer">Timer.</param>
        public void Register(Timer timer)
            => timer.TimerEvent += Msg;

        /// <summary>
        /// Unregister listener to timer.
        /// </summary>
        /// <param name="timer">Timer.</param>
        public void Unregister(Timer timer)
            => timer.TimerEvent -= Msg;

        public TimerListener2(Timer timer)
        {
            timer.TimerEvent += Msg;
        }

        private void Msg(object sender, TimerInfoEventArgs infoEventInfo)
        {
            Console.WriteLine($"There is another type of Listener!");
        }
    }
}

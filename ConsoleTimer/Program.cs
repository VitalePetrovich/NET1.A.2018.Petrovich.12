using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET1.A._2018.Petrovich._12;
using TimerListeners;

namespace ConsoleTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(TimeSpan.Parse("0:0:2"), new TimerInfoEventArgs() {Message = "New default timer event message."});
            TimerListener1 listener1 = new TimerListener1(timer);
            TimerListener1 listener2 = new TimerListener1(timer);
            TimerListener1 listener3 = new TimerListener1(timer);
            listener2.Unregister(timer);

            timer.Start(TimeSpan.Parse("0:0:3"));

            listener1.Unregister(timer);
            listener2.Register(timer);
            TimerListener2 listener4 = new TimerListener2(timer);

            timer.Start(new TimerInfoEventArgs() {Message = "Time to message it!"});

            Console.ReadKey();
        }
        
    }
}

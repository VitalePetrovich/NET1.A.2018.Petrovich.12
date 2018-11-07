using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NET1.A._2018.Petrovich._12
{
    public class Timer
    {
        public event EventHandler<TimerInfoEventArgs> TimerEvent = delegate { };

        private readonly TimeSpan time;
        private readonly TimerInfoEventArgs infoEventInfo;

        /// <summary>
        /// Method for call event TimerEvent.
        /// </summary>
        /// <param name="sender">Sender reference.</param>
        /// <param name="infoEventInfo">TimerInfo.</param>
        protected virtual void OnTimerEvent(object sender, TimerInfoEventArgs infoEventInfo)
        {
            TimerEvent(this, infoEventInfo);
        }

        #region ctors
        
        public Timer() : this(TimeSpan.Zero, new TimerInfoEventArgs() { Message = "Default timer event info." })
        {
        }

        public Timer(TimeSpan time) : this(time, new TimerInfoEventArgs() { Message = "Default timer event info." })
        {
        }

        public Timer(TimerInfoEventArgs infoEventInfo) : this(TimeSpan.Zero, infoEventInfo)
        {
        }

        public Timer(TimeSpan time, TimerInfoEventArgs infoEventInfo)
        {
            this.time = time;
            this.infoEventInfo = infoEventInfo;
        }

        #endregion

        /// <summary>
        /// Start timer with default time and info.
        /// </summary>
        public void Start()
            => Start(time, infoEventInfo);

        /// <summary>
        /// Start timer with current time and default info.
        /// </summary>
        /// <param name="time">Current time.</param>
        public void Start(TimeSpan time)
            => Start(time, infoEventInfo);

        /// <summary>
        /// Start timer with default time and current info.
        /// </summary>
        /// <param name="infoEventInfo">Current info.</param>
        public void Start(TimerInfoEventArgs infoEventInfo)
            => Start(time, infoEventInfo);

        /// <summary>
        /// Start timer with current time and info.
        /// </summary>
        /// <param name="time">Current time.</param>
        /// <param name="infoEventInfo">Current info.</param>
        public void Start(TimeSpan time, TimerInfoEventArgs infoEventInfo)
        {
            if (ReferenceEquals(infoEventInfo, null))
                throw new ArgumentNullException(nameof(infoEventInfo));
            
            Thread.Sleep(time);
           
            OnTimerEvent(this, infoEventInfo);
        }

    }
}

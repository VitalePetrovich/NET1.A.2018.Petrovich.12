using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET1.A._2018.Petrovich._12
{
    /// <summary>
    /// Class container for timer event information.
    /// </summary>
    public class TimerInfoEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}

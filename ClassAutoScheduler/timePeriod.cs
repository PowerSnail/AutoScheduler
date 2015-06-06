using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAutoScheduler
{
    class timePeriod
    {
        //Fields
        internal int Begin { get; set; }
        internal int End { get; set; }

        public timePeriod(int _begin, int _end)
        {
            this.Begin = _begin;
            this.End = _end;
        }
    }
}

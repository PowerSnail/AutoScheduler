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
        private static Dictionary<string, int> weekdays = new Dictionary<string, int>()
        {
            {"mo", 10000},
            {"tu", 20000},
            {"we", 30000},
            {"th", 40000},
            {"fr", 50000},
            {"sa", 60000},
            {"su", 70000}
        };

        public timePeriod(int _begin, int _end)
        {
            this.Begin = _begin;
            this.End = _end;
        }

        public static timePeriod parse(string time)
        {
            string wd = time.Substring(0, 2);
            int beg = weekdays[wd] + int.Parse(time.Substring(2, 4));
            int end = weekdays[wd] + int.Parse(time.Substring(6, 4));
            return new timePeriod(beg, end);
        }
    }
}

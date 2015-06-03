using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAutoScheduler
{
    class Session
    {
        //Fields
        timePeriod[] periods;

        public Session(timePeriod _period)
        {
            periods
        }
        public Course parse(string _str)
        {
            string[] times = _str.Split('|');
            Course cs = new Course();
            foreach (string s in times)
            {
                string[] info = s.Split(':');
                int d = info[0].Length;

                for (int i = 0; i < d; i += 2)
                {
                    cs.addSession(new Session(timePeriod.parse(info[0].Substring(i, 2))));
                }
            }

        }
    }
}

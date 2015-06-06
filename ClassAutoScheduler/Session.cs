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
        List<timePeriod> periods;

        public Session()
        {
            periods = new List<timePeriod>();
        }

        public void addTime(timePeriod _time)
        {
            periods.Add(_time);
        }

        public static Session parse(string _str)
        {
            Session ss = new Session();
            string[] times = _str.Split('|');

            foreach (string s in times)
            {
                int d = s.Length - 8;
                string t = s.Substring(d);
                for (int i = 0; i < d; i += 2)
                {
                    ss.addTime(timePeriod.parse(s.Substring(i, 2) + t));
                }
            }
            return ss;
        }
    }
}

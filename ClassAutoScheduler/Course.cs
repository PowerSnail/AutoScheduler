using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAutoScheduler
{
    class Course
    {
        List<Session> sessions;

        public int NumSession
        {
            get
            {
                return sessions.Count;
            }
        }

        public void addSession(Session _session)
        {
            sessions.Add(_session);
        }
    }
}

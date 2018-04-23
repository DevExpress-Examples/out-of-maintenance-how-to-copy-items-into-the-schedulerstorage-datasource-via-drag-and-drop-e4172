using DevExpress.Xpo;
using System;

namespace DxSample.PersistentObjects {
    public class Event :XPObject {
        public Event(Session session) : base(session) { }

        string fSubject;
        public string Subject {
            get { return fSubject; }
            set { SetPropertyValue<string>("Subject", ref fSubject, value); }
        }

        DateTime fStartTime;
        public DateTime StartTime {
            get { return fStartTime; }
            set { SetPropertyValue<DateTime>("StartTime", ref fStartTime, value); }
        }

        DateTime fEndTime;
        public DateTime EndTime {
            get { return fEndTime; }
            set { SetPropertyValue<DateTime>("EndTime", ref fEndTime, value); }
        }
    }
}

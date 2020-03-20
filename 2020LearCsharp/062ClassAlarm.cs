using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _062ClassAlarm
    {
        class EventAlarmArg : EventArgs
        {
            public string Location { get; set; }

            public EventAlarmArg(string location)
            {
                Location = location;
            }
        }

        class Alarm
        {
            public event EventHandler<EventAlarmArg> OnAlarmRaise = delegate { };

            public void RaiseAlarm(string location)
            {
                OnAlarmRaise(this,new EventAlarmArg(location));
            }
        }

        static void AlarmLisener1(object sender, EventAlarmArg e)
        {
            Console.WriteLine("Alarm lisener 1");
            Console.WriteLine($"Alarm lisener 1{ sender.ToString()} { e.Location.ToString() }");
        }
        static void AlarmLisener2(object sender, EventAlarmArg e)
        {
            Console.WriteLine("Alarm lisener 2");
            Console.WriteLine($"Alarm lisener 1{ sender.ToString()} { e.ToString() }");
        }

        public static void executeTest()
        {
            Alarm a = new Alarm();
            a.OnAlarmRaise += AlarmLisener1;
            a.OnAlarmRaise += AlarmLisener2;
            a.RaiseAlarm("Hello");
            Console.WriteLine("Finish Alarm");
            Console.ReadKey();
        }
    }
}

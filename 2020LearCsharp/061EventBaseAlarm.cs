using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
    public class _061EventBaseAlarm
    {
        class Alarm
        {
            public event EventHandler OnAlarmRaised = delegate { };

            public void RaiseAlarm()
            {
               
                    OnAlarmRaised(this, EventArgs.Empty);

                
            }
        }

        static void AlarmLisener1(object sender, EventArgs e)
        {
            Console.WriteLine("Alarm lisener 1");
            Console.WriteLine($"Alarm lisener 1{ sender.ToString()} { e.ToString() }");
        }
        static void AlarmLisener2(object sender, EventArgs e)
        {
            Console.WriteLine("Alarm lisener 2");            
            Console.WriteLine($"Alarm lisener 1{ sender.ToString()} { e.ToString() }");
        }

        public static void executeTest()
        {
            Alarm a = new Alarm();
            a.OnAlarmRaised += AlarmLisener1;
            a.OnAlarmRaised += AlarmLisener2;
            a.RaiseAlarm();
            Console.WriteLine("Finish Alarm");
            Console.ReadKey();
        }
    }
}

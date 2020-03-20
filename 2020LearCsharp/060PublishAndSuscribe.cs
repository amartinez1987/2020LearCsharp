using System;
using System.Collections.Generic;
using System.Text;

namespace _2020LearCsharp
{
   public  class _060PublishAndSuscribe
    {
        class Alarm
        {
            public Action OnAlarmRaised { set; get; }

            public void RaiseAlarm()
            {
                if (OnAlarmRaised != null)
                {
                    OnAlarmRaised();

                }
            }
        }

        static void AlarmLisener1()
        {
            Console.WriteLine("Alarm lisener 1");
        }
        static void AlarmLisener2()
        {
            Console.WriteLine("Alarm lisener 2");
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

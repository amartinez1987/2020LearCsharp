using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _2020LearCsharp
{
    public class _063AggregatinException
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
                List<Exception> exceptionList = new List<Exception>();
                foreach (Delegate handle in OnAlarmRaise.GetInvocationList())
                {
                    try
                    {
                        handle.DynamicInvoke(this, new EventAlarmArg(location));
                    }
                    catch (TargetInvocationException e)
                    {

                        exceptionList.Add(e);
                    }
                }

                if (exceptionList.Count > 0)
                {
                    exceptionList.ForEach(i => Console.WriteLine($"Error  {i.Message}")); 
                }
            }
        }

        static void AlarmLisener1(object sender, EventAlarmArg e)
        {
            Console.WriteLine("Alarm lisener 1");
            Console.WriteLine($"Alarm lisener 1{ e.Location.ToString() }");
            throw new Exception("Bang");
        }
        static void AlarmLisener2(object sender, EventAlarmArg e)
        {
            Console.WriteLine("Alarm lisener 2");
            Console.WriteLine($"Alarm lisener 2{ e.ToString() }");
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

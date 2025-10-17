using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Lessons
{
    public static class DataStore
    {
        public static string SharedHour1 { get; set; } = string.Empty;
        public static string SharedHour2 { get; set; } = string.Empty;

        public static string SharedMinute1 { get; set; } = string.Empty;
        public static string SharedMinute2 { get; set; } = string.Empty;

        public static string SharedSecond1 { get; set; } = string.Empty;
        public static string SharedSecond2 { get; set; } = string.Empty;


        public static string SharedAlarmTime { get; set; } = string.Empty;
    }
}

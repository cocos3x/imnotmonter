using UnityEngine;

namespace DataSystem.Globalization
{
    public static class StringFormat
    {
        // Methods
        private static System.IFormatProvider GetNumberFormat()
        {
            System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.GetCultureInfo(name:  -1610600671);
            if((-1610600671) == 0)
            {
                
            }
        
        }
        public static string FormatNumber(string format, object[] args)
        {
            System.IFormatProvider val_1 = DataSystem.Globalization.StringFormat.GetNumberFormat();
            return System.String.Format(provider:  format, format:  format, args:  args);
        }
        public static string FormatTime(string format, long time)
        {
            var val_7;
            var val_8;
            if(format != null)
            {
                    if((System.String.op_Equality(a:  format, b:  -1610599201)) != false)
            {
                    val_7 = 22712456;
                val_8 = 536889041;
                string val_2 = System.String.Format(format:  -1610597105, arg0:  536889041, arg1:  536889041);
                return;
            }
            
                if((System.String.op_Equality(a:  format, b:  -1610600209)) != false)
            {
                    var val_7 = 3600;
                val_7 = val_7 - R2;
                var val_4 = R3 + R2;
                val_8 = 536889041;
                val_7 = 536889041;
                string val_5 = System.String.Format(format:  -1610597101, arg0:  536889041, arg1:  536889041, arg2:  536889041);
                return;
            }
            
            }
            
            22710780 = new System.Exception(message:  22786288);
        }
        public static string FormatTime22(long time)
        {
            var val_4 = 86400;
            val_4 = val_4 - time;
            var val_5 = 3600;
            val_5 = val_5 - (R1 + time);
            long val_2 = R1 + time;
            string val_3 = System.String.Format(format:  -1610597101, arg0:  536889041, arg1:  536889041, arg2:  536889041);
        }
        public static string DateTimeToString(System.DateTime dateTime, DataSystem.Globalization.StringFormat.DateTimeFormat dateTimeFormat)
        {
            if(dateTimeFormat < 3)
            {
                    string val_1 = dateTime.dateData.ToString(format:  22043024 + (dateTimeFormat) << 2, provider:  0);
                return;
            }
            
            22710780 = new System.Exception(message:  22783656);
        }
        public static System.DateTime StringToDateTime(string timeString, DataSystem.Globalization.StringFormat.DateTimeFormat dateTimeFormat)
        {
            ulong val_3;
            var val_5;
            if(R2 == 2)
            {
                goto label_1;
            }
            
            if(R2 == 1)
            {
                goto label_2;
            }
            
            if(R2 != 0)
            {
                goto label_3;
            }
            
            val_5 = 22800520;
            goto label_9;
            label_2:
            val_5 = 22786656;
            goto label_9;
            label_1:
            val_5 = 22800524;
            label_9:
            System.DateTime val_1 = System.DateTime.ParseExact(s:  1115561776, format:  dateTimeFormat, provider:  -1610600903);
            mem2[0] = val_3;
            return new System.DateTime() {dateData = val_3};
            label_3:
            22710780 = new System.Exception(message:  22783656);
        }
        public static float FloatFromString(string s)
        {
            System.IFormatProvider val_1 = DataSystem.Globalization.StringFormat.GetNumberFormat();
            return System.Single.Parse(s:  s, provider:  s);
        }
        public static bool TryFloatFromString(string s, out float result)
        {
            System.IFormatProvider val_1 = DataSystem.Globalization.StringFormat.GetNumberFormat();
            float val_2 = System.Single.Parse(s:  s, provider:  s);
            result = s;
            return true;
        }
    
    }

}

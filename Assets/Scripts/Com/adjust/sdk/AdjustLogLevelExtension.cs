using UnityEngine;

namespace com.adjust.sdk
{
    public static class AdjustLogLevelExtension
    {
        // Methods
        public static string ToLowercaseString(com.adjust.sdk.AdjustLogLevel AdjustLogLevel)
        {
            var val_2;
            if((AdjustLogLevel - 1) <= 6)
            {
                    val_2 = mem[22291088 + ((AdjustLogLevel - 1)) << 2];
                val_2 = 22291088 + ((AdjustLogLevel - 1)) << 2;
                return;
            }
            
            val_2 = 22807156;
        }
        public static string ToUppercaseString(com.adjust.sdk.AdjustLogLevel AdjustLogLevel)
        {
            var val_2;
            if((AdjustLogLevel - 1) <= 6)
            {
                    val_2 = mem[22291056 + ((AdjustLogLevel - 1)) << 2];
                val_2 = 22291056 + ((AdjustLogLevel - 1)) << 2;
                return;
            }
            
            val_2 = 22795948;
        }
    
    }

}

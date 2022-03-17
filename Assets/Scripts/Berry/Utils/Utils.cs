using UnityEngine;

namespace Berry.Utils
{
    public static class Utils
    {
        // Methods
        public static T GetRandom<T>(System.Collections.Generic.ICollection<T> collection)
        {
            int val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            val_7 = collection;
            val_8 = __RuntimeMethodHiddenParam;
            val_9 = 22985753;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_9 = mem[__RuntimeMethodHiddenParam + 24];
            val_9 = __RuntimeMethodHiddenParam + 24;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_10 = val_7;
            val_11 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  val_7);
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_12 = val_7;
            label_24:
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_9 = (uint)val_10 & 65535;
            val_13 = val_7;
            if(val_7 == 0)
            {
                goto label_17;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_14 = val_7;
            val_15 = val_7;
            val_11 = val_11 - 1;
            if(val_11 != 0)
            {
                goto label_24;
            }
            
            val_8 = 1;
            val_7 = 0;
            goto label_39;
            label_17:
            val_8 = 1;
            val_15 = 0;
            val_7 = 0;
            label_39:
            if(val_7 != 0)
            {
                    var val_12 = 0;
                val_9 = 0;
                val_12 = val_12 + 1;
                val_9 = (uint)val_12 & 65535;
                val_16 = val_7;
            }
            
            if(val_8 == 0)
            {
                    return;
            }
            
            var val_7 = val_8 - 1;
            if(( + ((val_8 - 1)) << 2) == 73)
            {
                    return;
            }
        
        }
    
    }

}

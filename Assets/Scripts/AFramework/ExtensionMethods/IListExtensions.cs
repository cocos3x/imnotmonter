using UnityEngine;

namespace AFramework.ExtensionMethods
{
    public static class IListExtensions
    {
        // Methods
        public static void Shuffle<T>(System.Collections.Generic.IList<T> list)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_8 = __RuntimeMethodHiddenParam;
            var val_8 = 0;
            val_9 = 0;
            val_8 = val_8 + 1;
            val_9 = (uint)val_8 & 65535;
            val_11 = list;
            if(list < 2)
            {
                    return;
            }
            
            do
            {
                int val_2 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  list);
                var val_9 = 0;
                val_9 = val_9 + 1;
                val_12 = list;
                System.Collections.Generic.IList<T> val_4 = list - 1;
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_13 = list;
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_14 = list;
                val_8 = val_8;
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_10 = (uint)val_12 & 65535;
                val_15 = list;
            }
            while(list > 2);
        
        }
        public static T RandomItem<T>(System.Collections.Generic.IList<T> list)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = list;
            if(list != 0)
            {
                    val_8 = mem[__RuntimeMethodHiddenParam + 24];
                val_8 = __RuntimeMethodHiddenParam + 24;
                var val_7 = 0;
                val_7 = val_7 + 1;
                val_6 = (uint)val_7 & 65535;
                val_9 = list;
                int val_3 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  list);
                var val_8 = 0;
                val_6 = 0;
                val_8 = val_8 + 1;
                val_6 = (uint)val_8 & 65535;
                val_10 = list;
            }
            else
            {
                    22712420 = new System.IndexOutOfRangeException(message:  22783388);
            }
        
        }
        public static T RemoveRandom<T>(System.Collections.Generic.IList<T> list)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = list;
            if(list != 0)
            {
                    val_8 = mem[__RuntimeMethodHiddenParam + 24];
                val_8 = __RuntimeMethodHiddenParam + 24;
                var val_8 = 0;
                val_8 = val_8 + 1;
                val_9 = list;
                int val_3 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  list);
                val_10 = mem[__RuntimeMethodHiddenParam + 24 + 4];
                val_10 = __RuntimeMethodHiddenParam + 24 + 4;
                var val_9 = 0;
                val_8 = 0;
                val_9 = val_9 + 1;
                val_8 = (uint)val_9 & 65535;
                val_11 = list;
                var val_10 = 0;
                val_8 = 0;
                val_10 = val_10 + 1;
                val_8 = (uint)val_10 & 65535;
                val_12 = list;
                return;
            }
            
            22712420 = new System.IndexOutOfRangeException(message:  22783364);
        }
    
    }

}

using UnityEngine;

namespace Lean
{
    public static class LeanClassPool<T>
    {
        // Fields
        private static System.Collections.Generic.List<T> cache;
        
        // Methods
        public static T Spawn()
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
            }
            
            val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            val_3 = __RuntimeMethodHiddenParam + 12;
            if(val_2 == 1)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 12];
                val_3 = __RuntimeMethodHiddenParam + 12;
                val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96;
            if(val_2 == 1)
            {
                    val_4 = val_4;
            }
        
        }
        public static T Spawn(System.Action<T> onSpawn)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
            }
            
            val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            val_3 = __RuntimeMethodHiddenParam + 12;
            if(val_2 == 1)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 12];
                val_3 = __RuntimeMethodHiddenParam + 12;
                val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96;
            if(val_2 == 1)
            {
                    val_4 = val_4;
            }
        
        }
        public static T Spawn(System.Predicate<T> match)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
            }
            
            val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            val_3 = __RuntimeMethodHiddenParam + 12;
            if(val_2 == 1)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 12];
                val_3 = __RuntimeMethodHiddenParam + 12;
                val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96;
            if(val_2 == 1)
            {
                    val_4 = val_4;
            }
        
        }
        public static T Spawn(System.Predicate<T> match, System.Action<T> onSpawn)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
                val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
            }
            
            val_2 = val_2 & 512;
            if(match != 0)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_3 = __RuntimeMethodHiddenParam + 12 + 186;
                val_4 = __RuntimeMethodHiddenParam + 12;
                if(val_3 == 1)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 12];
                val_4 = __RuntimeMethodHiddenParam + 12;
                val_3 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_3 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
                val_6 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 92;
            }
            else
            {
                    val_7 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_7 = __RuntimeMethodHiddenParam + 12 + 186;
                val_4 = __RuntimeMethodHiddenParam + 12;
                if(val_7 == 1)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 12];
                val_4 = __RuntimeMethodHiddenParam + 12;
                val_7 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_7 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
                val_6 = (__RuntimeMethodHiddenParam + 12 + 96 + 4 + 92) - 1;
            }
            
            if(val_6 >= 0)
            {
                    val_8 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
                val_8 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
                if(val_8 == 1)
            {
                    val_8 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
                val_8 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
            }
            
                val_9 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_9 = __RuntimeMethodHiddenParam + 12 + 186;
                val_10 = __RuntimeMethodHiddenParam + 12;
                if(val_9 == 1)
            {
                    val_10 = mem[__RuntimeMethodHiddenParam + 12];
                val_10 = __RuntimeMethodHiddenParam + 12;
                val_9 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_9 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
                val_11 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 92;
                val_12 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_12 = __RuntimeMethodHiddenParam + 12 + 186;
                val_5 = __RuntimeMethodHiddenParam + 12;
                if(val_12 == 1)
            {
                    val_5 = mem[__RuntimeMethodHiddenParam + 12];
                val_5 = __RuntimeMethodHiddenParam + 12;
                val_12 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_12 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
                if(onSpawn == 0)
            {
                    return;
            }
            
                val_4 = mem[__RuntimeMethodHiddenParam + 12];
                val_4 = __RuntimeMethodHiddenParam + 12;
                val_13 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_13 = __RuntimeMethodHiddenParam + 12 + 186;
                val_14 = val_4;
                if(val_13 == 1)
            {
                    val_14 = mem[__RuntimeMethodHiddenParam + 12];
                val_14 = __RuntimeMethodHiddenParam + 12;
                val_13 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_13 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
                if(val_13 != 1)
            {
                    return;
            }
            
                return;
            }
            
            val_11 = 0;
        }
        public static void Despawn(T instance)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
            }
            
            val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            val_3 = __RuntimeMethodHiddenParam + 12;
            if(val_2 == 1)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 12];
                val_3 = __RuntimeMethodHiddenParam + 12;
                val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 28];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 28;
            if(val_2 == 1)
            {
                    val_4 = val_4;
            }
        
        }
        public static void Despawn(T instance, System.Action<T> onDespawn)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            if(instance == 0)
            {
                    return;
            }
            
            if(onDespawn != 0)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 186;
                val_2 = __RuntimeMethodHiddenParam + 12;
                if(val_1 == 1)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 12];
                val_2 = __RuntimeMethodHiddenParam + 12;
                val_1 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
            }
            
            val_3 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
            val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
            if(val_3 == 1)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4 + 186];
                val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 4 + 186;
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_4 = __RuntimeMethodHiddenParam + 12 + 186;
            val_5 = __RuntimeMethodHiddenParam + 12;
            if(val_4 == 1)
            {
                    val_5 = mem[__RuntimeMethodHiddenParam + 12];
                val_5 = __RuntimeMethodHiddenParam + 12;
                val_4 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_4 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
            val_6 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 36];
            val_6 = __RuntimeMethodHiddenParam + 12 + 96 + 36;
            if(val_4 == 1)
            {
                    val_6 = val_6;
            }
        
        }
        private static LeanClassPool<T>()
        {
            var val_1;
            var val_2;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 186;
            val_2 = __RuntimeMethodHiddenParam + 12;
            if(val_1 == 1)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 12];
                val_2 = __RuntimeMethodHiddenParam + 12;
                val_1 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
            mem2[0] = __RuntimeMethodHiddenParam + 12 + 96 + 40;
        }
    
    }

}

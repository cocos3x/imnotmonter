using UnityEngine;

namespace AFramework
{
    public class Singleton<T>
    {
        // Fields
        private static readonly T singleton;
        
        // Properties
        public static T instance { get; }
        public static T I { get; }
        
        // Methods
        public static T get_instance()
        {
            var val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            }
            
            if((__RuntimeMethodHiddenParam + 12 + 96 + 186) != 1)
            {
                    return;
            }
        
        }
        public static T get_I()
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
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
            
            val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 4;
            if(val_2 == 1)
            {
                    val_4 = val_4;
            }
        
        }
        public Singleton<T>()
        {
            if(this != 0)
            {
                    return;
            }
        
        }
        private static Singleton<T>()
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
            
            mem2[0] = __RuntimeMethodHiddenParam + 12 + 96 + 8;
        }
    
    }

}

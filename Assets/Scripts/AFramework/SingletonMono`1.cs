using UnityEngine;

namespace AFramework
{
    public class SingletonMono<T> : MonoBehaviour
    {
        // Fields
        private static T singleton;
        
        // Properties
        public static T instance { get; }
        public static T I { get; }
        
        // Methods
        public static bool IsInstanceValid()
        {
            if((mem[536891408] & true) != 0)
            {
                    return UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 12 + 96 + 92, y:  0);
            }
            
            if(mem[536891337] != 0)
            {
                    return UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 12 + 96 + 92, y:  0);
            }
            
            return UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 12 + 96 + 92, y:  0);
        }
        private void Reset()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 8});
            this.name = __RuntimeMethodHiddenParam + 12 + 96 + 8;
        }
        public static T get_instance()
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_8 = 22713552;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 92) == 0)
            {
                    System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 8});
                UnityEngine.Object val_3 = UnityEngine.Object.FindObjectOfType(type:  __RuntimeMethodHiddenParam + 12 + 96 + 8);
                val_8 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 92];
                val_8 = __RuntimeMethodHiddenParam + 12 + 96 + 92;
                val_9 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4];
                val_9 = __RuntimeMethodHiddenParam + 12 + 96 + 4;
                val_10 = 0;
                if((__RuntimeMethodHiddenParam + 12 + 96 + 8) != 0)
            {
                    val_10 = __RuntimeMethodHiddenParam + 12 + 96 + 8;
                if((__RuntimeMethodHiddenParam + 12 + 96 + 8) == 0)
            {
                    val_10 = 0;
            }
            
            }
            
                mem2[0] = val_10;
                if((__RuntimeMethodHiddenParam + 12 + 96 + 92) == 0)
            {
                    UnityEngine.GameObject val_5 = 536887303;
                val_5 = new UnityEngine.GameObject();
                System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 8});
                string val_7 = -1610602383(-1610602383) + __RuntimeMethodHiddenParam + 12 + 96 + 8(__RuntimeMethodHiddenParam + 12 + 96 + 8) + -1610602237(-1610602237);
                if(val_5 != 0)
            {
                    val_5.name = -1610602383;
            }
            else
            {
                    val_5.name = -1610602383;
            }
            
                val_11 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_11 = __RuntimeMethodHiddenParam + 12 + 186;
                val_12 = __RuntimeMethodHiddenParam + 12;
                if(val_11 == 1)
            {
                    val_12 = mem[__RuntimeMethodHiddenParam + 12];
                val_12 = __RuntimeMethodHiddenParam + 12;
                val_11 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_11 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
                val_8 = mem[__RuntimeMethodHiddenParam + 12 + 96];
                val_8 = __RuntimeMethodHiddenParam + 12 + 96;
                mem2[0] = val_5;
            }
            
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
            
            val_3 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 16];
            val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 16;
            if(val_1 == 1)
            {
                    val_3 = val_3;
            }
        
        }
        public SingletonMono<T>()
        {
            if(this != 0)
            {
                    return;
            }
        
        }
    
    }

}

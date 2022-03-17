using UnityEngine;

namespace AFramework
{
    public class ManualSingletonMono<T> : MonoBehaviour
    {
        // Fields
        private static T <instance>k__BackingField;
        
        // Properties
        public static T instance { get; set; }
        public static T I { get; }
        
        // Methods
        public static T get_instance()
        {
            if((__RuntimeMethodHiddenParam + 12 + 96 + 186) != 1)
            {
                    return;
            }
        
        }
        private static void set_instance(T value)
        {
            mem2[0] = value;
        }
        public static bool IsInstanceValid()
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
            
            if((mem[536891408] & true) != 0)
            {
                    return UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 12 + 96 + 4, y:  0);
            }
            
            if(mem[536891337] != 0)
            {
                    return UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 12 + 96 + 4, y:  0);
            }
            
            return UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 12 + 96 + 4, y:  0);
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
            
            val_3 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4];
            val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 4;
            if(val_1 == 1)
            {
                    val_3 = val_3;
            }
        
        }
        private void Reset()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 12});
            this.name = __RuntimeMethodHiddenParam + 12 + 96 + 12;
        }
        protected virtual void Awake()
        {
            if((__RuntimeMethodHiddenParam + 12 + 96 + 4) != 0)
            {
                    return;
            }
            
            if((this != 0) && (this == 0))
            {
                
            }
        
        }
        protected void OnDestroy()
        {
            if((__RuntimeMethodHiddenParam + 12 + 96 + 4) != 1162312432)
            {
                    return;
            }
            
            goto __RuntimeMethodHiddenParam + 12 + 96 + 16;
        }
        public ManualSingletonMono<T>()
        {
            if(this != 0)
            {
                    return;
            }
        
        }
    
    }

}

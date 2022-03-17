using UnityEngine;

namespace Ferr
{
    public abstract class Singleton<T> : MonoBehaviour
    {
        // Fields
        private static T _instance;
        
        // Properties
        public static T Instance { get; }
        public static bool Instantiated { get; }
        
        // Methods
        public static T get_Instance()
        {
            var val_2;
            var val_3;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 92) == 0)
            {
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
            
            }
            
            if((__RuntimeMethodHiddenParam + 12 + 96 + 186) != 1)
            {
                    return;
            }
        
        }
        public static bool get_Instantiated()
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
        public static void EnsureInstantiated()
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 92) != 0)
            {
                    return;
            }
            
            val_16 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_16 = __RuntimeMethodHiddenParam + 12 + 186;
            val_17 = __RuntimeMethodHiddenParam + 12;
            if(val_16 == 1)
            {
                    val_17 = mem[__RuntimeMethodHiddenParam + 12];
                val_17 = __RuntimeMethodHiddenParam + 12;
                val_16 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_16 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
            val_18 = mem[__RuntimeMethodHiddenParam + 12 + 96];
            val_18 = __RuntimeMethodHiddenParam + 12 + 96;
            mem2[0] = __RuntimeMethodHiddenParam + 12 + 96 + 12;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 92) == 0)
            {
                    System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 16});
                string val_4 = -1610604543(-1610604543) + __RuntimeMethodHiddenParam + 12 + 96 + 16(__RuntimeMethodHiddenParam + 12 + 96 + 16);
                UnityEngine.Object val_5 = UnityEngine.Resources.Load(path:  -1610604543);
                if((-1610604543) != 0)
            {
                    DropdownItem val_7 = UnityEngine.Object.Instantiate<DropdownItem>(original:  -1610604543);
                val_19 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_19 = __RuntimeMethodHiddenParam + 12 + 186;
                val_20 = __RuntimeMethodHiddenParam + 12;
                if(val_19 == 1)
            {
                    val_20 = mem[__RuntimeMethodHiddenParam + 12];
                val_20 = __RuntimeMethodHiddenParam + 12;
                val_19 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_19 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
                val_18 = mem[__RuntimeMethodHiddenParam + 12 + 96];
                val_18 = __RuntimeMethodHiddenParam + 12 + 96;
                mem2[0] = -1610604543;
            }
            
            }
            
            if((__RuntimeMethodHiddenParam + 12 + 96 + 92) == 0)
            {
                    System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 16});
                string val_10 = -1610602177(-1610602177) + __RuntimeMethodHiddenParam + 12 + 96 + 16(__RuntimeMethodHiddenParam + 12 + 96 + 16);
                UnityEngine.GameObject val_11 = 536887303;
                val_11 = new UnityEngine.GameObject(name:  -1610602177);
                System.Type val_12 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 16});
                UnityEngine.Component val_13 = val_11.AddComponent(componentType:  __RuntimeMethodHiddenParam + 12 + 96 + 16);
                val_18 = val_11;
                val_21 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4];
                val_21 = __RuntimeMethodHiddenParam + 12 + 96 + 4;
                val_22 = 0;
                if(val_18 != 0)
            {
                    val_22 = val_18;
                if(val_18 == 0)
            {
                    val_22 = 0;
            }
            
            }
            
                mem2[0] = val_22;
            }
            
            if((__RuntimeMethodHiddenParam + 12 + 96 + 92) != 0)
            {
                    return;
            }
            
            System.Type val_15 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 16});
            mem[536882227] = __RuntimeMethodHiddenParam + 12 + 96 + 16;
            UnityEngine.Debug.LogErrorFormat(format:  -1610609065, args:  536882211);
        }
        protected virtual void Awake()
        {
            UnityEngine.Object val_6 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 92];
            val_6 = __RuntimeMethodHiddenParam + 12 + 96 + 92;
            if(val_6 != 0)
            {
                    val_6 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 92];
                val_6 = __RuntimeMethodHiddenParam + 12 + 96 + 92;
                if(val_6 != 1234435856)
            {
                    UnityEngine.GameObject val_3 = this.gameObject;
                System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 16});
                mem[536882227] = __RuntimeMethodHiddenParam + 12 + 96 + 16;
                UnityEngine.Debug.LogErrorFormat(context:  1234435856, format:  -1610609013, args:  536882211);
                UnityEngine.GameObject val_5 = this.gameObject;
                this.SetActive(value:  false);
                return;
            }
            
            }
            
            mem2[0] = this;
        }
        protected virtual void OnDestroy()
        {
            mem2[0] = 0;
        }
        protected Singleton<T>()
        {
            if(this != 0)
            {
                    return;
            }
        
        }
    
    }

}

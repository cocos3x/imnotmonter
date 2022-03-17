using UnityEngine;
public class Singleton<T> : MonoBehaviour
{
    // Fields
    private static T _instance;
    private static object _lock;
    private static bool applicationIsQuitting;
    
    // Properties
    public static T Instance { get; }
    
    // Methods
    public static T get_Instance()
    {
        var val_18;
        var val_19;
        string val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        val_18 = __RuntimeMethodHiddenParam;
        val_19 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_19 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_19 == 1)
        {
                val_19 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_19 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92 + 8) != 0)
        {
                val_20 = 0;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 4});
            if((__RuntimeMethodHiddenParam + 12 + 96 + 4) != 0)
        {
                val_20 = __RuntimeMethodHiddenParam + 12 + 96 + 4;
        }
        
            val_21 = 0;
            string val_2 = -1610602301(-1610602301) + val_20 + -1610612095(-1610612095);
            UnityEngine.Debug.LogWarning(message:  -1610602301);
            return;
        }
        
        val_22 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_22 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_22 == 1)
        {
                val_22 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_22 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        System.Threading.Monitor.Enter(obj:  __RuntimeMethodHiddenParam + 12 + 96 + 92 + 4, lockTaken: ref  bool val_3 = true);
        val_23 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_23 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_23 == 1)
        {
                val_23 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_23 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92) != 0)
        {
            goto label_132;
        }
        
        System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 4});
        UnityEngine.Object val_6 = UnityEngine.Object.FindObjectOfType(type:  __RuntimeMethodHiddenParam + 12 + 96 + 4);
        val_24 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_24 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_24 == 1)
        {
                val_24 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_24 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        val_25 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 8];
        val_25 = __RuntimeMethodHiddenParam + 12 + 96 + 8;
        val_26 = 0;
        if((__RuntimeMethodHiddenParam + 12 + 96 + 4) != 0)
        {
                val_26 = __RuntimeMethodHiddenParam + 12 + 96 + 4;
            if(val_26 == 0)
        {
                val_26 = 0;
        }
        
        }
        
        mem2[0] = val_26;
        System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 4});
        UnityEngine.Object[] val_8 = UnityEngine.Object.FindObjectsOfType(type:  __RuntimeMethodHiddenParam + 12 + 96 + 4);
        if((__RuntimeMethodHiddenParam + 12 + 96 + 4 + 12) >= 2)
        {
            goto label_62;
        }
        
        val_27 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_27 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_27 == 1)
        {
                val_27 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_27 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92) != 0)
        {
            goto label_75;
        }
        
        UnityEngine.GameObject val_10 = 536887303;
        val_10 = new UnityEngine.GameObject();
        val_28 = mem[__RuntimeMethodHiddenParam + 12 + 186];
        val_28 = __RuntimeMethodHiddenParam + 12 + 186;
        val_29 = __RuntimeMethodHiddenParam + 12;
        if(val_28 == 1)
        {
                val_29 = mem[__RuntimeMethodHiddenParam + 12];
            val_29 = __RuntimeMethodHiddenParam + 12;
            val_28 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_28 = __RuntimeMethodHiddenParam + 12 + 186;
        }
        
        val_30 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_30 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_30 == 1)
        {
                val_30 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_30 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        mem2[0] = val_10;
        System.Type val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 4});
        string val_12 = -1610611969(-1610611969) + __RuntimeMethodHiddenParam + 12 + 96 + 4(__RuntimeMethodHiddenParam + 12 + 96 + 4);
        val_10.name = -1610611969;
        UnityEngine.Object.DontDestroyOnLoad(target:  536887303);
        val_25 = 536882401;
        mem[536882417] = -1610602303;
        val_31 = 0;
        System.Type val_13 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 4});
        if((__RuntimeMethodHiddenParam + 12 + 96 + 4) == 0)
        {
            goto label_101;
        }
        
        val_32 = __RuntimeMethodHiddenParam + 12 + 96 + 4;
        if((__RuntimeMethodHiddenParam + 12 + 96 + 4) == 0)
        {
            goto label_133;
        }
        
        if(val_32 == 0)
        {
            goto label_103;
        }
        
        val_31 = val_32;
        goto label_133;
        label_62:
        UnityEngine.Debug.LogError(message:  -1610602299);
        val_33 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_33 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_33 == 1)
        {
                val_33 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_33 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        val_34 = mem[__RuntimeMethodHiddenParam + 12 + 96];
        val_34 = __RuntimeMethodHiddenParam + 12 + 96;
        if((__RuntimeMethodHiddenParam + 12 + 96 + 186) != 1)
        {
            goto label_158;
        }
        
        goto label_158;
        label_75:
        val_35 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_35 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_35 == 1)
        {
                val_35 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_35 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        UnityEngine.GameObject val_14 = __RuntimeMethodHiddenParam + 12 + 96 + 92.gameObject;
        string val_15 = __RuntimeMethodHiddenParam + 12 + 96 + 92.name;
        string val_16 = -1610602297(-1610602297) + __RuntimeMethodHiddenParam + 12 + 96 + 92(__RuntimeMethodHiddenParam + 12 + 96 + 92);
        UnityEngine.Debug.Log(message:  -1610602297);
        goto label_132;
        label_101:
        val_32 = 0;
        goto label_133;
        label_103:
        val_31 = val_32;
        label_133:
        mem[536882421] = val_31;
        mem[536882425] = -1610612347;
        val_36 = 0;
        if(val_10 == 0)
        {
            goto label_138;
        }
        
        val_37 = val_10;
        if(val_10 == 0)
        {
            goto label_142;
        }
        
        if(val_37 == 0)
        {
            goto label_140;
        }
        
        val_36 = val_37;
        goto label_142;
        label_138:
        val_37 = 0;
        goto label_142;
        label_140:
        val_36 = val_37;
        label_142:
        mem[536882429] = val_36;
        mem[536882433] = -1610612069;
        string val_17 = +536882401;
        UnityEngine.Debug.Log(message:  536882401);
        label_132:
        val_38 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_38 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_38 == 1)
        {
                val_38 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_38 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        val_34 = mem[__RuntimeMethodHiddenParam + 12 + 96];
        val_34 = __RuntimeMethodHiddenParam + 12 + 96;
        label_158:
        val_20 = 1;
        val_21 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 92];
        val_21 = __RuntimeMethodHiddenParam + 12 + 96 + 92;
        if(0 != 0)
        {
                System.Threading.Monitor.Exit(obj:  __RuntimeMethodHiddenParam + 12 + 96 + 92 + 4);
        }
        
        if(val_20 == 0)
        {
                return;
        }
        
        var val_18 = val_20 - 1;
    }
    public void OnDestroy()
    {
        var val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_1 == 1)
        {
                val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        mem2[0] = 1;
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
        object val_1 = 536891193;
        val_1 = new System.Object();
        mem2[0] = val_1;
        mem2[0] = 0;
    }

}

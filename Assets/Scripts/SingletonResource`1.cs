using UnityEngine;
public class SingletonResource<T> : MonoBehaviour
{
    // Fields
    private static T instance;
    protected static string path;
    
    // Properties
    public static T Instance { get; }
    
    // Methods
    public static T get_Instance()
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_9 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_9 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_9 == 1)
        {
                val_9 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_9 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92) != 0)
        {
            goto label_35;
        }
        
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 8});
        UnityEngine.Object val_3 = UnityEngine.Object.FindObjectOfType(type:  __RuntimeMethodHiddenParam + 12 + 96 + 8);
        val_10 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_10 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_10 == 1)
        {
                val_10 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_10 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        val_11 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 92];
        val_11 = __RuntimeMethodHiddenParam + 12 + 96 + 92;
        val_12 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4];
        val_12 = __RuntimeMethodHiddenParam + 12 + 96 + 4;
        val_13 = 0;
        if((__RuntimeMethodHiddenParam + 12 + 96 + 8) != 0)
        {
                val_13 = __RuntimeMethodHiddenParam + 12 + 96 + 8;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 8) == 0)
        {
                val_13 = 0;
        }
        
        }
        
        mem2[0] = val_13;
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92) != 0)
        {
            goto label_35;
        }
        
        val_14 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_14 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_14 == 1)
        {
                val_14 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_14 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 8});
        string val_6 = __RuntimeMethodHiddenParam + 12 + 96 + 92 + 4(__RuntimeMethodHiddenParam + 12 + 96 + 92 + 4) + __RuntimeMethodHiddenParam + 12 + 96 + 8(__RuntimeMethodHiddenParam + 12 + 96 + 8);
        UnityEngine.Object val_7 = UnityEngine.Resources.Load(path:  __RuntimeMethodHiddenParam + 12 + 96 + 92 + 4);
        val_15 = 0;
        UnityEngine.Object val_8 = UnityEngine.Object.Instantiate(original:  __RuntimeMethodHiddenParam + 12 + 96 + 92 + 4);
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92 + 4) == 0)
        {
            goto label_52;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92 + 4) == 0)
        {
            goto label_53;
        }
        
        val_15 = __RuntimeMethodHiddenParam + 12 + 96 + 92 + 4;
        goto label_54;
        label_53:
        label_52:
        label_54:
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
        
        val_11 = val_15;
        val_12 = mem[__RuntimeMethodHiddenParam + 12 + 96];
        val_12 = __RuntimeMethodHiddenParam + 12 + 96;
        mem2[0] = val_11;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
        label_35:
        val_18 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_18 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_18 == 1)
        {
                val_18 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_18 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        if((__RuntimeMethodHiddenParam + 12 + 96 + 186) != 1)
        {
                return;
        }
    
    }
    public virtual void Awake()
    {
        if(this == 0)
        {
            
        }
    
    }
    protected bool CheckInstance()
    {
        var val_2;
        var val_3;
        val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
        val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        if(val_2 == 1)
        {
                val_2 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
        }
        
        val_3 = 1;
        if(545288080 == (__RuntimeMethodHiddenParam + 12 + 96 + 20))
        {
                return (bool)val_3;
        }
        
        val_3 = 0;
        UnityEngine.Object.Destroy(obj:  545288080);
        return (bool)val_3;
    }
    public SingletonResource<T>()
    {
        if(this != 0)
        {
                return;
        }
    
    }
    private static SingletonResource<T>()
    {
        mem2[0] = -1610612735;
    }

}

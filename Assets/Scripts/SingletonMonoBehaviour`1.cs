using UnityEngine;
public class SingletonMonoBehaviour<T> : MonoBehaviour
{
    // Fields
    private static T instance;
    
    // Properties
    public static T Instance { get; }
    
    // Methods
    public static T get_Instance()
    {
        string val_9;
        var val_10;
        var val_11;
        string val_12;
        var val_13;
        var val_14;
        val_9 = 22713552;
        if((__RuntimeMethodHiddenParam + 12 + 96 + 92) == 0)
        {
                System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 8});
            UnityEngine.Object val_3 = UnityEngine.Object.FindObjectOfType(type:  __RuntimeMethodHiddenParam + 12 + 96 + 8);
            val_9 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 92];
            val_9 = __RuntimeMethodHiddenParam + 12 + 96 + 92;
            val_10 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4];
            val_10 = __RuntimeMethodHiddenParam + 12 + 96 + 4;
            val_11 = 0;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 8) != 0)
        {
                val_11 = __RuntimeMethodHiddenParam + 12 + 96 + 8;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 8) == 0)
        {
                val_11 = 0;
        }
        
        }
        
            mem2[0] = val_11;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 92) == 0)
        {
                val_12 = 0;
            System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 8});
            if((__RuntimeMethodHiddenParam + 12 + 96 + 8) != 0)
        {
                val_12 = __RuntimeMethodHiddenParam + 12 + 96 + 8;
        }
        
            string val_6 = val_12 + -1610599825(-1610599825);
            UnityEngine.Debug.LogError(message:  val_12);
            UnityEngine.GameObject val_7 = 536887303;
            val_7 = new UnityEngine.GameObject();
            val_13 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_13 = __RuntimeMethodHiddenParam + 12 + 186;
            val_14 = __RuntimeMethodHiddenParam + 12;
            if(val_13 == 1)
        {
                val_14 = mem[__RuntimeMethodHiddenParam + 12];
            val_14 = __RuntimeMethodHiddenParam + 12;
            val_13 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_13 = __RuntimeMethodHiddenParam + 12 + 186;
        }
        
            val_10 = mem[__RuntimeMethodHiddenParam + 12 + 96];
            val_10 = __RuntimeMethodHiddenParam + 12 + 96;
            mem2[0] = val_7;
            System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 8});
            val_9 = __RuntimeMethodHiddenParam + 12 + 96 + 8;
            val_7.name = val_9;
        }
        
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
        if(544616080 == (__RuntimeMethodHiddenParam + 12 + 96 + 20))
        {
                return (bool)1;
        }
        
        1 = 0;
        UnityEngine.Object.Destroy(obj:  544616080);
        return (bool)1;
    }
    public void Reset()
    {
        mem2[0] = 0;
    }
    public static bool Exists()
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
    public SingletonMonoBehaviour<T>()
    {
        if(this != 0)
        {
                return;
        }
    
    }

}

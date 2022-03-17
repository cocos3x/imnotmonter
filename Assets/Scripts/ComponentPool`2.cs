using UnityEngine;
private class Ferr2DT_PathTerrain.ComponentPool<T, U>
{
    // Fields
    private System.Collections.Generic.List<T> _pool;
    private System.Collections.Generic.List<U> _mapItems;
    
    // Properties
    public System.Collections.Generic.List<T> Pool { get; }
    public System.Collections.Generic.List<U> Map { get; }
    
    // Methods
    public System.Collections.Generic.List<T> get_Pool()
    {
    
    }
    public System.Collections.Generic.List<U> get_Map()
    {
    
    }
    public Ferr2DT_PathTerrain.ComponentPool<T, U>(UnityEngine.GameObject aFrom, System.Collections.Generic.List<U> aMapTo, bool aConsolidate)
    {
        var val_6;
        int val_7;
        var val_8;
        val_1 = new System.Object();
        mem[1152921509355353144] = __RuntimeMethodHiddenParam + 12 + 96 + 4;
        if(aConsolidate == false)
        {
            goto label_4;
        }
        
        mem[1152921509355353148] = __RuntimeMethodHiddenParam + 12 + 96 + 12;
        val_6 = 0;
        goto label_6;
        label_13:
        val_6 = 1;
        label_6:
        if(val_6 < val_1)
        {
            goto label_13;
        }
        
        goto label_14;
        label_4:
        mem[1152921509355353148] = val_1;
        label_14:
        val_7 = (aFrom + 12) - (__RuntimeMethodHiddenParam + 12 + 96 + 4);
        if(val_7 >= 1)
        {
                val_8 = 22713552;
            do
        {
            var val_5 = mem[536891407];
            val_5 = val_5 & 512;
            if(UnityEngine.Application.isPlaying != false)
        {
                UnityEngine.Object.Destroy(obj:  mem[1152921509355353144]);
        }
        else
        {
                UnityEngine.Object.DestroyImmediate(obj:  mem[1152921509355353144]);
        }
        
            val_7 = val_7 - 1;
        }
        while(mem[1152921509355353144] != 0);
        
            return;
        }
        
        val_8 = 0;
        if((UnityEngine.Mathf.Abs(value:  val_7)) < 1)
        {
                return;
        }
        
        do
        {
            val_8 = val_8 + 1;
        }
        while(val_8 < (UnityEngine.Mathf.Abs(value:  val_7)));
    
    }
    public T Get(U aFromData)
    {
        if(R4 == 0)
        {
            
        }
    
    }

}

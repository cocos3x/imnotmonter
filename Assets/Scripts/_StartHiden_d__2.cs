using UnityEngine;
private sealed class AutoHiden.<StartHiden>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public AutoHiden <>4__this;
    private UnityEngine.Color <newColor>5__2;
    private float <f>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AutoHiden.<StartHiden>d__2(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_15;
        AutoHiden val_16;
        float val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_25;
        val_15 = 0;
        val_16 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_15;
        }
        
            this.<>1__state = 0;
            UnityEngine.Transform val_1 = val_16.transform;
            UnityEngine.Transform val_2 = val_16.GetChild(index:  0);
            UnityEngine.Transform val_3 = val_16.GetComponent<UnityEngine.Transform>();
            UnityEngine.Material val_4 = val_16.material;
            UnityEngine.Color val_5 = color;
            val_17 = 1f;
            this.<f>5__3 = 1f;
        }
        else
        {
                float val_16 = -0.175f;
            this.<>1__state = 0;
            val_16 = (this.<f>5__3) + val_16;
            this.<f>5__3 = val_16;
            if((this.<>1__state) < 1)
        {
                UnityEngine.GameObject val_6 = val_16.gameObject;
            val_15 = 0;
            UnityEngine.Object.Destroy(obj:  val_16);
            UnityEngine.Object.Destroy(obj:  this.<>4__this.linktocandy);
            return (bool)val_15;
        }
        
        }
        
        mem[1152921509491492912] = val_17;
        UnityEngine.Transform val_7 = val_16.transform;
        System.Collections.IEnumerator val_8 = val_16.GetEnumerator();
        val_18 = val_16;
        label_38:
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_19 = val_18;
        if(val_18 == 0)
        {
            goto label_22;
        }
        
        var val_18 = 0;
        val_18 = val_18 + 1;
        val_20 = val_18;
        if(val_18 != 0)
        {
                val_21 = 0;
        }
        else
        {
                val_21 = 0;
        }
        
        UnityEngine.Transform val_11 = GetComponent<UnityEngine.Transform>();
        UnityEngine.Material val_12 = material;
        color = new UnityEngine.Color() {r = this.<newColor>5__2, g = R4, b = R5, a = mem[1152921509491492912]};
        goto label_38;
        label_22:
        val_22 = 0;
        val_23 = 22711796;
        if(val_18 != 0)
        {
                val_18 = val_22;
            val_23 = 0;
            val_23 = val_23 + 1;
            val_25 = val_18;
            val_22 = val_18;
        }
        
        if(1 != 0)
        {
                var val_14 = 1 - 1;
        }
        
        UnityEngine.WaitForSeconds val_15 = 536896849;
        val_15 = new UnityEngine.WaitForSeconds(seconds:  val_17);
        this.<>2__current = val_15;
        val_15 = 1;
        this.<>1__state = val_15;
        return (bool)val_15;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        22713476 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}

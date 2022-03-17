using UnityEngine;
private sealed class JSONNode.<get_DeepChilds>d__19 : IEnumerable<com.adjust.sdk.JSONNode>, IEnumerable, IEnumerator<com.adjust.sdk.JSONNode>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private com.adjust.sdk.JSONNode <>2__current;
    private int <>l__initialThreadId;
    public com.adjust.sdk.JSONNode <>4__this;
    private System.Collections.Generic.IEnumerator<com.adjust.sdk.JSONNode> <>7__wrap1;
    private System.Collections.Generic.IEnumerator<com.adjust.sdk.JSONNode> <>7__wrap2;
    
    // Properties
    private com.adjust.sdk.JSONNode System.Collections.Generic.IEnumerator<com.adjust.sdk.JSONNode>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JSONNode.<get_DeepChilds>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
        this.<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
        var val_3 = this;
        if(((this.<>1__state) & (~1)) != 4)
        {
            goto label_0;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        goto label_2;
        label_0:
        if((this.<>1__state) != 1)
        {
                return;
        }
        
        label_1:
        R4.<>m__Finally2();
        label_2:
        R4.<>m__Finally1();
    }
    private bool MoveNext()
    {
        int val_8;
        System.Collections.Generic.IEnumerator<com.adjust.sdk.JSONNode> val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_8 = 0;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 1)
        {
                return (bool)val_8;
        }
        
        val_9 = this.<>7__wrap2;
        goto label_37;
        label_1:
        this.<>1__state = 0;
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_10 = (uint)val_8 & 65535;
        val_11 = this.<>4__this;
        val_9 = this;
        this.<>7__wrap1 = this.<>4__this;
        this.<>1__state = 2;
        goto label_10;
        label_37:
        this.<>1__state = 3;
        var val_9 = 0;
        val_10 = 0;
        val_9 = val_9 + 1;
        val_10 = (uint)val_9 & 65535;
        val_12 = this.<>7__wrap2;
        if((this.<>7__wrap2) != 0)
        {
            goto label_19;
        }
        
        this.<>m__Finally2();
        mem2[0] = 0;
        val_9 = this.<>7__wrap1;
        label_10:
        var val_11 = mem[this.<>7__wrap1];
        if((mem[this.<>7__wrap1] + 178) == 0)
        {
            goto label_21;
        }
        
        var val_10 = 0;
        label_23:
        val_10 = 0;
        if((mem[this.<>7__wrap1] + 88 + 0) == 536888219)
        {
            goto label_22;
        }
        
        val_10 = val_10 + 1;
        val_10 = (uint)val_10 & 65535;
        if(val_10 < (mem[this.<>7__wrap1] + 178))
        {
            goto label_23;
        }
        
        label_21:
        val_13 = mem[this.<>7__wrap1];
        goto label_24;
        label_22:
        var val_3 = (mem[this.<>7__wrap1] + 88) + 0;
        val_11 = val_11 + (((mem[this.<>7__wrap1] + 88 + 0) + 4) << 3);
        val_13 = val_11 + 188;
        label_24:
        if((mem[this.<>7__wrap1]) == 0)
        {
            goto label_25;
        }
        
        var val_13 = mem[this.<>7__wrap1];
        if((mem[this.<>7__wrap1] + 178) == 0)
        {
            goto label_27;
        }
        
        var val_12 = 0;
        label_29:
        if((mem[this.<>7__wrap1] + 88 + 0) == 536876663)
        {
            goto label_28;
        }
        
        val_12 = val_12 + 1;
        if(((uint)val_12 & 65535) < (mem[this.<>7__wrap1] + 178))
        {
            goto label_29;
        }
        
        label_27:
        val_14 = mem[this.<>7__wrap1];
        goto label_30;
        label_28:
        var val_4 = (mem[this.<>7__wrap1] + 88) + 0;
        val_13 = val_13 + (((mem[this.<>7__wrap1] + 88 + 0) + 4) << 3);
        val_14 = val_13 + 188;
        label_30:
        System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> val_5 = mem[this.<>7__wrap1].DeepChilds;
        var val_15 = mem[this.<>7__wrap1];
        if((mem[this.<>7__wrap1] + 178) == 0)
        {
            goto label_33;
        }
        
        var val_14 = 0;
        label_35:
        if((mem[this.<>7__wrap1] + 88 + 0) == 536876383)
        {
            goto label_34;
        }
        
        val_14 = val_14 + 1;
        if(((uint)val_14 & 65535) < (mem[this.<>7__wrap1] + 178))
        {
            goto label_35;
        }
        
        label_33:
        val_15 = mem[this.<>7__wrap1];
        goto label_36;
        label_34:
        var val_6 = (mem[this.<>7__wrap1] + 88) + 0;
        val_15 = val_15 + (((mem[this.<>7__wrap1] + 88 + 0) + 4) << 3);
        val_15 = val_15 + 188;
        label_36:
        this.<>7__wrap2 = mem[this.<>7__wrap1];
        goto label_37;
        label_25:
        this.<>m__Finally1();
        val_8 = 0;
        mem2[0] = val_8;
        return (bool)val_8;
        label_19:
        var val_17 = mem[this.<>7__wrap2];
        if((mem[this.<>7__wrap2] + 178) == 0)
        {
            goto label_40;
        }
        
        var val_16 = 0;
        label_42:
        val_10 = 0;
        if((mem[this.<>7__wrap2] + 88 + 0) == 536876663)
        {
            goto label_41;
        }
        
        val_16 = val_16 + 1;
        val_10 = (uint)val_16 & 65535;
        if(val_10 < (mem[this.<>7__wrap2] + 178))
        {
            goto label_42;
        }
        
        label_40:
        val_16 = mem[this.<>7__wrap2];
        goto label_43;
        label_41:
        var val_7 = (mem[this.<>7__wrap2] + 88) + 0;
        val_17 = val_17 + (((mem[this.<>7__wrap2] + 88 + 0) + 4) << 3);
        val_16 = val_17 + 188;
        label_43:
        this.<>2__current = mem[this.<>7__wrap2];
        val_8 = 1;
        this.<>1__state = val_8;
        return (bool)val_8;
    }
    private void <>m__Finally1()
    {
        var val_1;
        this.<>1__state = 0;
        if((this.<>7__wrap1) == 0)
        {
                return;
        }
        
        var val_1 = 0;
        val_1 = val_1 + 1;
        val_1 = this.<>7__wrap1;
        goto mem[(1152921504681713664 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
    }
    private void <>m__Finally2()
    {
        var val_1;
        this.<>1__state = 2;
        if((this.<>7__wrap2) == 0)
        {
                return;
        }
        
        var val_1 = 0;
        val_1 = val_1 + 1;
        val_1 = this.<>7__wrap2;
        goto mem[(1152921504681713664 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
    }
    private com.adjust.sdk.JSONNode System.Collections.Generic.IEnumerator<com.adjust.sdk.JSONNode>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        22713476 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }
    private System.Collections.Generic.IEnumerator<com.adjust.sdk.JSONNode> System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode>.GetEnumerator()
    {
        int val_4;
        var val_5;
        if((this.<>1__state) == 2)
        {
                val_4 = this.<>l__initialThreadId;
            if(val_4 == System.Environment.CurrentManagedThreadId)
        {
                this.<>1__state = 0;
            val_5 = this;
            return;
        }
        
        }
        
        object val_2 = 536899467;
        val_5 = val_2;
        val_4 = 0;
        val_2 = new System.Object();
        mem[536899475] = val_4;
        mem[536899483] = System.Environment.CurrentManagedThreadId;
        mem[536899487] = this.<>4__this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode>.GetEnumerator();
    }

}

using UnityEngine;
private sealed class JSONArray.<get_Childs>d__13 : IEnumerable<com.adjust.sdk.JSONNode>, IEnumerable, IEnumerator<com.adjust.sdk.JSONNode>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private com.adjust.sdk.JSONNode <>2__current;
    private int <>l__initialThreadId;
    public com.adjust.sdk.JSONArray <>4__this;
    private System.Collections.Generic.List.Enumerator<com.adjust.sdk.JSONNode> <>7__wrap1;
    
    // Properties
    private com.adjust.sdk.JSONNode System.Collections.Generic.IEnumerator<com.adjust.sdk.JSONNode>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public JSONArray.<get_Childs>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
        this.<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 3)
        {
                return;
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        int val_3;
        List.Enumerator<com.adjust.sdk.JSONNode> val_4;
        val_3 = 0;
        if((this.<>1__state) != 0)
        {
                if((this.<>1__state) != 1)
        {
                return (bool)val_3;
        }
        
            val_4 = this.<>7__wrap1;
        }
        else
        {
                this.<>1__state = 0;
            List.Enumerator<T> val_1 = GetEnumerator();
        }
        
        this.<>1__state = 2;
        if((this.<>7__wrap1.MoveNext()) != false)
        {
                this.<>2__current = -1073729019;
            val_3 = 1;
            this.<>1__state = val_3;
            return (bool)val_3;
        }
        
        this.<>m__Finally1();
        return (bool)val_3;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap1.Dispose();
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
        
        object val_2 = 536899457;
        val_5 = val_2;
        val_4 = 0;
        val_2 = new System.Object();
        mem[536899465] = val_4;
        mem[536899473] = System.Environment.CurrentManagedThreadId;
        mem[536899477] = this.<>4__this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode>.GetEnumerator();
    }

}

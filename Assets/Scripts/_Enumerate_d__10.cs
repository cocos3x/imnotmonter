using UnityEngine;
private sealed class FixedBitArray3.<Enumerate>d__10 : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private bool <>2__current;
    private int <>l__initialThreadId;
    public FerrPoly2Tri.FixedBitArray3 <>4__this;
    public FerrPoly2Tri.FixedBitArray3 <>3__<>4__this;
    private int <i>5__2;
    
    // Properties
    private bool System.Collections.Generic.IEnumerator<System.Boolean>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FixedBitArray3.<Enumerate>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
        this.<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return false;
        }
        
            val_2 = 0;
            this.<i>5__2 = val_2;
            this.<>1__state = 0;
        }
        else
        {
                this.<>1__state = 0;
            val_2 = (this.<i>5__2) + 1;
            this.<i>5__2 = val_2;
            if(val_2 >= 3)
        {
                return false;
        }
        
        }
        
        this.<>2__current = this.<>4__this.Item[0];
        this.<>1__state = 1;
        return true;
    }
    private bool System.Collections.Generic.IEnumerator<System.Boolean>.get_Current()
    {
        return (bool)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        22713476 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }
    private System.Collections.Generic.IEnumerator<bool> System.Collections.Generic.IEnumerable<System.Boolean>.GetEnumerator()
    {
        int val_4;
        var val_5;
        if((this.<>1__state) != 2)
        {
            goto label_2;
        }
        
        val_4 = this.<>l__initialThreadId;
        if(val_4 != System.Environment.CurrentManagedThreadId)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_5 = this;
        goto label_3;
        label_2:
        object val_2 = 536899039;
        val_5 = val_2;
        val_4 = 0;
        val_2 = new System.Object();
        mem[536899047] = val_4;
        mem[536899055] = System.Environment.CurrentManagedThreadId;
        if(val_5 == 0)
        {
            goto label_4;
        }
        
        label_3:
        mem[536899059] = this.<>3__<>4__this;
        mem[536899061] = 0;
        return;
        label_4:
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Boolean>.GetEnumerator();
    }

}

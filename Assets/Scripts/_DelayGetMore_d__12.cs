using UnityEngine;
private sealed class MoregameItemUi.<DelayGetMore>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MoregameItemUi.<DelayGetMore>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        var val_4;
        object val_5;
        System.Func<System.Boolean> val_6;
        int val_7;
        val_3 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            val_4 = 536900049;
            if(((mem[536900236] & true) == 0) && (mem[536900165] == 0))
        {
                val_4 = 536900049;
        }
        
            val_5 = mem[536900141];
            val_6 = mem[mem[536900141] + 4];
            val_6 = mem[536900141] + 4;
            if(val_6 == 0)
        {
                if(((mem[536900236] & true) == 0) && (mem[536900165] == 0))
        {
                val_5 = mem[536900141];
        }
        
            val_6 = 536875159;
            val_6 = new System.Func<System.Boolean>(object:  val_5, method:  new IntPtr(1610676615));
            mem2[0] = val_6;
        }
        
            UnityEngine.WaitUntil val_2 = 536896879;
            val_2 = new UnityEngine.WaitUntil(predicate:  536875159);
            this.<>2__current = val_2;
            val_7 = 1;
            val_3 = 1;
        }
        else
        {
                val_7 = 0;
        }
        
        this.<>1__state = val_7;
        return (bool)val_3;
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

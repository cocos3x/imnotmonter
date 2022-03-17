using UnityEngine;
private sealed class Water2D_Spawner.<Start>d__59 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Water2D.Water2D_Spawner <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Water2D_Spawner.<Start>d__59(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_9;
        int val_10;
        val_9 = 0;
        if((this.<>1__state) > 4)
        {
                return (bool);
        }
        
        var val_1 = 6799948 + (6799948 + (this.<>1__state) << 2);
        if((this.<>1__state) == 4)
        {
                val_9 = val_9 & 929959536;
            val_9 = val_9 & (((int)R8) >> (val_9 & 929959536));
            val_9 = val_9 & (((int)IP) >> 1);
            mem2[0] = (((val_9 & 929959536) & ((int)R8) >> (val_9 & 929959536)) & ((int)IP) >> 1) + (((val_9 & 929959536) & ((int)R8) >> (val_9 & 929959536)) & ((int)IP) >> 1);
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_2 = 536896849;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_2;
        val_10 = 1;
        val_9 = 1;
        this.<>1__state = ;
        return (bool);
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

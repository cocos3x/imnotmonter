using UnityEngine;
private sealed class ProCamera2DTriggerBoundaries.<TurnOffPreviousTrigger>d__39 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerBoundaries trigger;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DTriggerBoundaries.<TurnOffPreviousTrigger>d__39(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_2;
        if((this.<>1__state) != 1)
        {
                val_2 = 0;
            if((this.<>1__state) != 0)
        {
                return val_2;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForEndOfFrame val_1 = 536896839;
            val_1 = new UnityEngine.WaitForEndOfFrame();
            this.<>2__current = val_1;
            this.<>1__state = 1;
            return true;
        }
        
        this.<>1__state = 0;
        val_2 = false;
        this.trigger._transitioning = val_2;
        return val_2;
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

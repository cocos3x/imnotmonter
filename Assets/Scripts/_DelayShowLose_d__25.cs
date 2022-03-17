using UnityEngine;
private sealed class BossRopeRescueController.<DelayShowLose>d__25 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float timeDelay;
    public BossRopeRescueController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BossRopeRescueController.<DelayShowLose>d__25(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        object val_3;
        val_2 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = 536896849;
            val_3 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>2__current = val_3;
            val_2 = 1;
            this.<>1__state = val_2;
            return (bool)val_2;
        }
        
        val_3 = this.<>4__this;
        this.<>1__state = 0;
        if((this.<>4__this.showLose) == false)
        {
                return (bool)val_2;
        }
        
        val_2 = 0;
        GameTool.EventDispatcherExtension.PostEvent(sender:  val_3, eventID:  5);
        return (bool)val_2;
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

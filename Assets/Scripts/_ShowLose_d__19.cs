using UnityEngine;
private sealed class LoadLevelRopeManager.<ShowLose>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LoadLevelRopeManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoadLevelRopeManager.<ShowLose>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = 536896849;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>2__current = val_1;
            val_3 = 1;
            this.<>1__state = val_3;
            return (bool)val_3;
        }
        
        this.<>1__state = 0;
        this.<>4__this.canReSpawnGameMenu = true;
        val_3 = 0;
        GameTool.EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  32);
        AFramework.UI.BaseUIMenu val_2 = AFramework.UI.CanvasManager.Push(identifier:  -1610605289, initParams:  null);
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

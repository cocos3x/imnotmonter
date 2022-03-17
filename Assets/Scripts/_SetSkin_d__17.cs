using UnityEngine;
private sealed class PlayerController.<SetSkin>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PlayerController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerController.<SetSkin>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
            this.<>1__state = 0;
            536875159 = new System.Func<System.Boolean>(object:  this.<>4__this, method:  new IntPtr(1610680375));
            UnityEngine.WaitUntil val_2 = 536896879;
            val_2 = new UnityEngine.WaitUntil(predicate:  536875159);
            this.<>2__current = val_2;
            val_6 = 1;
            this.<>1__state = val_6;
            return (bool)val_6;
        }
        
        this.<>1__state = 0;
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_5 = -1073708883.SkinSelectedID.ToString();
        this.<>4__this.skeleton.SetSkin(skinName:  723078676);
        val_6 = 0;
        this.<>4__this.skeleton.SetSlotsToSetupPose();
        this.<>4__this.skeleton.Update(deltaTime:  null);
        return (bool)val_6;
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

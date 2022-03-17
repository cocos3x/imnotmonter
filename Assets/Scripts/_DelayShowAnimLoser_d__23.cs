using UnityEngine;
private sealed class BossRopeRescueController.<DelayShowAnimLoser>d__23 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float time;
    public BossRopeRescueController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BossRopeRescueController.<DelayShowAnimLoser>d__23(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        var val_5;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = 536896849;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>2__current = val_1;
            val_4 = 1;
            this.<>1__state = val_4;
            return (bool)val_4;
        }
        
        this.<>1__state = 0;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609909, volume:  null);
        val_5 = 536884273;
        if(((mem[536884460] & true) == 0) && (mem[536884389] == 0))
        {
                val_5 = 536884273;
        }
        
        536882991 = new System.Action(object:  this.<>4__this, method:  new IntPtr(1610680163));
        if((this.<>4__this) != 0)
        {
                this.<>4__this.SetAnimBoss(name:  mem[536884365] + 12, loop:  false, _callBack:  536882991);
        }
        else
        {
                0.SetAnimBoss(name:  mem[536884365] + 12, loop:  false, _callBack:  536882991);
        }
        
        val_4 = 0;
        this.<>4__this.ShowText(loser:  true);
        return (bool)val_4;
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

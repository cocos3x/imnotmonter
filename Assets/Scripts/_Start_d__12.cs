using UnityEngine;
private sealed class BossRopeRescueController.<Start>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BossRopeRescueController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BossRopeRescueController.<Start>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_6;
        int val_8;
        var val_9;
        var val_10;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_8 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
        this.<>1__state = 0;
        val_9 = 536884273;
        if(((mem[536884460] & true) == 0) && (mem[536884389] == 0))
        {
                val_9 = 536884273;
        }
        
        this.<>4__this.SetAnimBoss(name:  mem[536884365] + 8, loop:  true, _callBack:  0);
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        int val_2 = -1073701005.TotalHeathBoss;
        if((this.<>4__this) == 0)
        {
            goto label_7;
        }
        
        this.<>4__this.<heathBoss>k__BackingField = val_2;
        goto label_8;
        label_1:
        this.<>1__state = 0;
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609903, volume:  null);
        this.<>4__this.ShowText(loser:  false);
        val_10 = 536884273;
        if(((mem[536884460] & true) == 0) && (mem[536884389] == 0))
        {
                val_10 = 536884273;
        }
        
        val_8 = 0;
        536882991 = new System.Action(object:  this.<>4__this, method:  new IntPtr(1610680147));
        this.<>4__this.SetAnimBoss(name:  mem[536884365] + 20, loop:  false, _callBack:  536882991);
        return (bool)val_8;
        label_7:
        mem[40] = val_2;
        label_8:
        this.<>4__this.cavansHeath.SetActive(value:  false);
        UnityEngine.Vector2 val_5 = sizeDelta;
        this.<>4__this.maxLineHeath = val_6;
        UnityEngine.WaitForSeconds val_7 = 536896849;
        val_7 = new UnityEngine.WaitForSeconds(seconds:  val_5.x);
        this.<>2__current = val_7;
        val_8 = 1;
        this.<>1__state = val_8;
        return (bool)val_8;
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

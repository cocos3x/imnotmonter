using UnityEngine;
private sealed class AutoLaser.<Auto>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public AutoLaser <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AutoLaser.<Auto>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_6 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = 536896849;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_1;
        val_6 = 1;
        this.<>1__state = val_6;
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        DropdownItem val_2 = this.<>4__this.Laser.GetComponentInChildren<DropdownItem>();
        val_6 = 0;
        this.<>4__this.Laser.SetLaserState(enabledStatus:  true);
        this.<>4__this.audio.PlaySound();
        UnityEngine.Coroutine val_3 = this.<>4__this.StartCoroutine(methodName:  -1610610013);
        return (bool)val_6;
        label_2:
        this.<>1__state = 0;
        DropdownItem val_4 = this.<>4__this.Laser.GetComponentInChildren<DropdownItem>();
        this.<>4__this.Laser.SetLaserState(enabledStatus:  false);
        this.<>4__this.audio.StopSound();
        UnityEngine.WaitForSeconds val_5 = 536896849;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_5;
        val_6 = 1;
        this.<>1__state = 2;
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

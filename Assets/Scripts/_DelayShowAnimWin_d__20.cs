using UnityEngine;
private sealed class PlayerController.<DelayShowAnimWin>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PlayerController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerController.<DelayShowAnimWin>d__20(int <>1__state)
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
        val_4 = 0;
        if((this.<>1__state) != 1)
        {
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
        if(mem[3221266280] == true)
        {
                return (bool)val_4;
        }
        
        val_5 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_5 = 536884781;
        }
        
        string val_3 = Berry.Utils.Utils.GetRandom<System.String>(collection:  mem[536884873] + 20);
        val_4 = 0;
        this.<>4__this.SetAnimation(name:  mem[536884873] + 20, loop:  true, _callBack:  0);
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

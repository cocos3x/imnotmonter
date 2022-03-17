using UnityEngine;
private sealed class SpinManager.<ShowNothanks>d__43 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SpinManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SpinManager.<ShowNothanks>d__43(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if((this.<>1__state) != 1)
        {
                val_6 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
            this.<>1__state = 0;
            UnityEngine.GameObject val_1 = this.<>4__this.getSkinBtn.gameObject;
            this.<>4__this.getSkinBtn.SetActive(value:  false);
            UnityEngine.GameObject val_2 = this.<>4__this.x2Btn.gameObject;
            this.<>4__this.x2Btn.SetActive(value:  true);
            UnityEngine.GameObject val_3 = this.<>4__this.nothanksBtn.gameObject;
            this.<>4__this.nothanksBtn.SetActive(value:  false);
            UnityEngine.WaitForSeconds val_4 = 536896849;
            val_4 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>2__current = val_4;
            val_6 = 1;
            this.<>1__state = val_6;
            return (bool)val_6;
        }
        
        this.<>1__state = 0;
        val_6 = 0;
        UnityEngine.GameObject val_5 = this.<>4__this.nothanksBtn.gameObject;
        this.<>4__this.nothanksBtn.SetActive(value:  true);
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

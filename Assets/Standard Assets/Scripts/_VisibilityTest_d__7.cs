using UnityEngine;
private sealed class VisibilityControl.<VisibilityTest>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Vectrosity.VisibilityControl <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VisibilityControl.<VisibilityTest>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_3 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
        this.<>2__current = 0;
        this.<>1__state = 0;
        val_3 = 1;
        this.<>1__state = val_3;
        return (bool)val_3;
        label_1:
        this.<>1__state = 0;
        UnityEngine.Transform val_1 = this.<>4__this.GetComponent<UnityEngine.Transform>();
        val_3 = 0;
        if((this.<>4__this.isVisible) == true)
        {
                return (bool)val_3;
        }
        
        val_3 = 0;
        this.<>4__this.m_vectorLine.active = false;
        return (bool)val_3;
        label_2:
        this.<>2__current = 0;
        this.<>1__state = 0;
        val_3 = 1;
        this.<>1__state = 2;
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
